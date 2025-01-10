import faiss
import numpy as np

def create_faiss_index(embeddings_np):
    dimension = embeddings_np.shape[1]
    M = 32
    ef_construction = 200
    index = faiss.IndexHNSWFlat(dimension, M)
    index.hnsw.efConstruction = ef_construction
    index.add(embeddings_np)
    index.hnsw.efSearch = 50
    return index
