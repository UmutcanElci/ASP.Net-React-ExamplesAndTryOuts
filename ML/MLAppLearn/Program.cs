using MLAppLearn;


string text = Console.ReadLine();

// Add input data
var sampleData = new SentimentModel.ModelInput()
{
    Col0 = text,
};

// Load model and predict output of sample data
var result = SentimentModel.Predict(sampleData);

// If Prediction is 1, sentiment is "Positive"; otherwise, sentiment is "Negative"
var sentiment = result.PredictedLabel == 1 ? "Positive" : "Negative"; // if == 1 Positive else Negative 
Console.WriteLine($"Text: {sampleData.Col0}\nSentiment: {sentiment}");

// This is data is about positive and negative comments if comment positive returns 1 negative returns 0