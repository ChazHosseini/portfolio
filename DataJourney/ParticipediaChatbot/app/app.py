import streamlit as st
from chatbot import generate_answer
from data_processing import load_data, process_data
from embeddings import load_or_create_embeddings, embedding_model
from faiss_index import create_faiss_index

# Load and process data
df = load_data("../data/CaseDataset.xlsx")
df = process_data(df)

# Load embeddings and create FAISS index
embedding_file_path = "../data/embeddings.pt"
embeddings = load_or_create_embeddings(df, embedding_file_path)
embeddings_np = embeddings.cpu().numpy()
index = create_faiss_index(embeddings_np)

# Streamlit interface
st.title("Participedia Chatbot")

if "MostRelevantAnswer" not in st.session_state:
    st.session_state.MostRelevantAnswer = None

question = st.text_input("Ask me about cases:")

if question:
    st.write("Question:", question)
    answer = generate_answer(question, df, index, embedding_model)
    st.write(answer)
