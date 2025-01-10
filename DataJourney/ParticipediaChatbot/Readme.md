# Participedia Chatbot

## Overview
The **Participedia Chatbot** is an innovative web application designed to assist users in exploring and understanding civic engagement projects from around the world. By leveraging powerful AI and machine learning models, this chatbot delivers precise, context-aware responses about case studies related to participatory democracy, civic engagement, and public policy-making. The app uses natural language processing (NLP) to provide insightful answers, drawing from a dataset of global participatory cases.

This chatbot operates as a **Retrieval-Augmented Generation (RAG) system** on a **tabular dataset**. It retrieves relevant case studies from the dataset based on the user's query and then generates human-like answers using advanced AI models.

## Key Features
- **Civic Engagement Knowledgebase**: Access a comprehensive dataset of participatory projects, including details about their participants, methods, and outcomes.
- **RAG System**: Combines **retrieval** of relevant case studies with **generative** response generation for insightful, context-aware answers.
- **AI-Powered Responses**: The chatbot utilizes advanced NLP models, including Google’s Gemini 1.5 and Sentence Transformers, to provide intelligent and context-aware answers.
- **Fast and Scalable**: The use of FAISS indexing ensures rapid search and retrieval of relevant cases, even with a large dataset.
- **Streamlit Interface**: A sleek and user-friendly web interface powered by Streamlit that makes it easy to interact with the chatbot.

## Technologies Used
- **Streamlit**: For building the interactive web interface.
- **Sentence Transformers**: For embedding and similarity-based search.
- **FAISS**: A fast search library for finding similar cases in large datasets.
- **Google Gemini 1.5**: For generating conversational and context-aware answers.
- **Pandas**: For data manipulation and processing.
- **Torch**: For handling deep learning-based model operations.
- **Excel**: For storing and organizing the dataset.

## How It Works
The chatbot analyzes user input and retrieves the most relevant case studies based on semantic similarity. Using FAISS indexing and precomputed embeddings from the SentenceTransformer model, the app can efficiently find related cases. It then utilizes the Gemini model to generate human-like responses by combining the retrieved information with generative language modeling. This enables the chatbot to provide meaningful insights about civic engagement initiatives, making it a **Retrieval-Augmented Generation (RAG) system** for a **tabular dataset**.

## Hardware Considerations
Due to hardware limitations on the developer's laptop, **FAISS-CPU** has been used in the application. However, if you have a machine with a powerful GPU, you can modify the code to use **FAISS-GPU** for significantly faster search and retrieval performance. To switch to `faiss-gpu`, you would need to install the GPU version of FAISS and adjust the code accordingly.
