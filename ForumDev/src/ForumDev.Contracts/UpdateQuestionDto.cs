namespace ForumDev.Contracts;

public record UpdateQuestionDto(string Title, string Body, Guid UserId, Guid[] TagIds);