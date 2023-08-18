using Amazon.S3.Model;
using Amazon.S3;

var s3Client = new AmazonS3Client();

await using var inputStream = new FileStream("./Resume.JonathanGregorsky.pdf", FileMode.Open, FileAccess.Read);

var putObjectRequest = new PutObjectRequest
{
    BucketName = "jxg-bucket",
    Key = "docs/Resume.JonathanGregorsky.pdf",
    ContentType = "application/pdf",
    InputStream = inputStream
};

await s3Client.PutObjectAsync(putObjectRequest);