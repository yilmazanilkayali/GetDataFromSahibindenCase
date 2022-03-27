using GetDataFromSahibinden.com;
//
SahibindenConnector sahibindenConnector = new SahibindenConnector();
sahibindenConnector.PrintShowcaseItems();
WriteToTextFile writeText = new WriteToTextFile();
writeText.WriteToFile();

