using System;
using OutSystems.Application.RestConsume.Definitions;
using HttpMethod = OutSystems.Application.RestConsume.Definitions.HttpMethod;

namespace ssConectaProveedores;

public class NewNotification_50dcbe257f504574a443e2c5f2fcff95 : IRestConsumeApiMethod {
    public Guid Key { get; } = Guid.Parse("50dcbe25-7f50-4574-a443-e2c5f2fcff95");
    public string Name => "NewNotification";
    public IRestConsumeApi RestConsumeApi { get; }
    public HttpMethod HttpMethod => HttpMethod.Post;
    public string UrlPath => "NewNotification";
    public RequestFormat RequestFormat => OutSystems.Application.RestConsume.Definitions.RequestFormat.Json;
    public ResponseFormat ResponseFormat => OutSystems.Application.RestConsume.Definitions.ResponseFormat.Json;
    public IReadOnlyList<IRestConsumeApiMethodInputParameter> InputParameters { get; }
    public IReadOnlyList<IRestConsumeApiMethodOutputParameter> OutputParameters { get; }
    public TimeSpan? Timeout { get; } = null;

    public NewNotification_50dcbe257f504574a443e2c5f2fcff95(Notifications_90eca6e8b896426c930ac11800b3905c restConsumeApi) {
        RestConsumeApi = restConsumeApi;
        InputParameters = [
            new RestConsumeApiMethodInputParameter(Guid.Parse("55629202-993f-407b-acea-504793de60e8"), "notificationinfo", this, false, ParameterType.Structure, new RestConsumeStructure_NewNotification2_f2b86c6e9a171aacffc6ca49bb5b5aaf(),  true, ParameterSendIn.Body,null, true, null, MultipartPartSource.SingleStaticPart),

        ];

        OutputParameters = [
            new RestConsumeApiMethodOutputParameter(Guid.Parse("43a3156f-be7a-435d-a876-05a9b5785420"), "Response", this, false, ParameterType.Structure, new RestConsumeStructure_APIOutput2_8509a484f6b6eac99c83feddd35d5004(), ParameterReceiveIn.Body, null),

        ];
    }
}