import google.generativeai as genai
from faiss_index import create_faiss_index
from embeddings import load_or_create_embeddings
from data_processing import load_data, process_data
import os

# PLEASE INSERT YOUR GEMINI API KEY 
os.environ["API_KEY"] = "AIzaSyB6noe1FxWvr9iqqfKHYJolzvMBZhZ6oB0"
genai.configure(api_key=os.environ["API_KEY"])
model = genai.GenerativeModel("gemini-1.5-flash")

def find_relevant_records(question, embedding_model, df, index, top_n=5):
    question_embedding = embedding_model.encode(question, convert_to_tensor=True)
    question_embedding_np = question_embedding.cpu().numpy().reshape(1, -1)
    D, I = index.search(question_embedding_np, k=top_n)
    relevant_df = df.iloc[I.flatten()].reset_index(drop=True)
    relevant_df['similarity_score'] = D.flatten()
    return relevant_df

def generate_answer(question, df, index, embedding_model):
    relevant_records = find_relevant_records(question, embedding_model, df, index)
    if not relevant_records.empty:
        most_relevant_answer = relevant_records.iloc[0]['combined_context']
        prompt = (
            f"Based on the most relevant case provided below, answer the user's question in a conversational and precise manner. "
            f"Use only the provided information and ensure all numbers are included in the response. "
            f"Case Details: '{most_relevant_answer}'\n"
            f"User Question: '{question}'"
        )
        try:
            answer = model.generate_content(prompt).text
        except Exception as e:
            answer = f"The server did not respond or an error occurred. WE ARE USING THE FREE GEMINI: {str(e)}"
    else:
        answer = "I couldn't find any relevant cases for your question."
    return answer
