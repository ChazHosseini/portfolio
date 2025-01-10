# embeddings.py
import os
import torch
from sentence_transformers import SentenceTransformer

# Initialize the embedding model globally
embedding_model = SentenceTransformer('all-MiniLM-L6-v2')

def load_or_create_embeddings(df, embedding_file_path):
    if os.path.exists(embedding_file_path):
        embeddings = torch.load(embedding_file_path)  # Load cached embeddings
    else:
        embeddings = embedding_model.encode(df['combined_context'].tolist(), convert_to_tensor=True)
        torch.save(embeddings, embedding_file_path)
    
    return embeddings
