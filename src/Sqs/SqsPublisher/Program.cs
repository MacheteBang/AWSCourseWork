using System.Text.Json;
using Amazon.SQS;
using Amazon.SQS.Model;
using Sqs.SqsPublisher;

var sqsClient = new AmazonSQSClient();

var customer = new CustomerCreated
{
    Id = Guid.NewGuid(),
    Email = "jonathan@mmmpizza.net",
    FullName = "Jonathan Gregorsky",
    DateOfBirth = new DateTime(1977, 10, 07),
    GitHubUsername = "MacheteBang"
};

var queueUrlResponse = await sqsClient.GetQueueUrlAsync("customers");

var sendMessageRequest = new SendMessageRequest
{
    QueueUrl = queueUrlResponse.QueueUrl,
    MessageBody = JsonSerializer.Serialize(customer),
    MessageAttributes = new Dictionary<string, MessageAttributeValue>
    {
        {
            "MessageType", new MessageAttributeValue
            {
                DataType = "String",
                StringValue = nameof(CustomerCreated)
            }
        }
    }
};

var response = await sqsClient.SendMessageAsync(sendMessageRequest);

Console.WriteLine();