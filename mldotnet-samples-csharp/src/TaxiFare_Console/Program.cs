// This file was auto-generated by ML.NET Model Builder

using TaxiFare_Console;

// Create single instance of sample data from first line of dataset for model input
var sampleData = new Prediction.ModelInput() {
    Vendor_id = @"CMT",
    Rate_code = 1F,
    Passenger_count = 1F,
    Payment_type = @"CRD",
};

// Make a single prediction on the sample data and print results
var predictionResult = Prediction.Predict(sampleData);

Console.WriteLine("Using model to make single prediction -- Comparing actual Fare_amount with predicted Fare_amount from sample data...\n\n");

Console.WriteLine($"Vendor_id: {@"CMT"}");
Console.WriteLine($"Rate_code: {1F}");
Console.WriteLine($"Passenger_count: {1F}");
Console.WriteLine($"Payment_type: {@"CRD"}");
Console.WriteLine($"Fare_amount: {8F}");

Console.WriteLine($"\n\nPredicted Fare_amount: {predictionResult.Score}\n\n");
Console.WriteLine("=============== End of process, hit any key to finish ===============");
Console.ReadKey();