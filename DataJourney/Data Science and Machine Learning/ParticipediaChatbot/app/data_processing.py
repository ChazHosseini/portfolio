import pandas as pd

def load_data(file_path):
    return pd.read_excel(file_path)

def combine_columns_with_labels(row):
    return (
        f"ID: {row['id']} | Type: {row['type']} | Title: {row['title']} | URL: {row['url']} | "
        f"Description: {row['description']} | Post Date: {row['post_date']} | Updated Date: {row['updated_date']} | "
        f"Number of Participants: {row['number_of_participants_1']} | Recruitment Method: {row['recruitment_method']} | "
        f"Targeted Participants: {row['targeted_participants_1']} | Format: {row['facetoface_online_or_both']} | "
        f"City: {row['city']} | Province: {row['province']} | Country: {row['country']} | "
        f"Latitude: {row['latitude']} | Longitude: {row['longitude']} | "
        f"Specific Methods: {row['specific_methods_tools_techniques_titles']} | General Issues: {row['general_issues_1']} | "
        f"Specific Topics: {row['specific_topics_1']} | Purposes: {row['purposes_1']} | "
        f"Approaches: {row['approaches_1']} | Insights: {row['insights_outcomes_1']} | "
        f"Decision Methods: {row['decision_methods_1']} | Facilitator Training: {row['facilitator_training']} | "
        f"Learning Resources: {row['learning_resources_1']} | Primary Organizer: {row['primary_organizer_title']} | "
        f"Funder: {row['funder']} | Funder Types: {row['funder_types_1']}"
    )

def process_data(df):
    df['combined_context'] = df.apply(combine_columns_with_labels, axis=1)
    df['combined_context'] = df['combined_context'].str.lower()
    return df
