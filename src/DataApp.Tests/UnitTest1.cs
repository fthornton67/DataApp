namespace DataApp.Tests;

public class UnitTest1
{
    [Fact]
    public void ConsolidateDataFromSources_WhenDataIdIs1_Returns0()
    {
        // Arrange
        var dataManager = new DataManager();
        var dataId = 1;

        // Act
        var result = dataManager.ConsolidateDataFromSources(dataId);

        // Assert
        Assert.Equal(0, result);
    }

    [Fact]
    public void ConsolidateDataFromSources_WhenDataIdIs2_Returns0()
    {
        // Arrange
        var dataManager = new DataManager();
        var dataId = 2;

        // Act
        var result = dataManager.ConsolidateDataFromSources(dataId);

        // Assert
        Assert.Equal(0, result);
    }

    [Fact]
    public void ConsolidateDataFromSources_WhenDataIdIs3_Returns0()
    {
        // Arrange
        var dataManager = new DataManager();
        var dataId = 3;

        // Act
        var result = dataManager.ConsolidateDataFromSources(dataId);

        // Assert
        Assert.Equal(0, result);
    }

    [Fact]
    public void ConsolidateDataFromSources_WhenDataIdIsLessThan0_ReturnsNegative1()
    {
        // Arrange
        var dataManager = new DataManager();
        var dataId = -1;

        // Act
        var result = dataManager.ConsolidateDataFromSources(dataId);

        // Assert
        Assert.Equal(-1, result);
    }

    [Fact]
    public void ConsolidateDataFromSources_WhenDataFetchedIsNullOrWhiteSpace_ReturnsNegative2()
    {
        // Arrange
        var dataManager = new DataManager();
        var dataId = 5;
        //_dataFetcher.FetchData = () => null;

        // Act
        var result = dataManager.ConsolidateDataFromSources(dataId);

        // Assert
        Assert.Equal(-2, result);
    }



}
