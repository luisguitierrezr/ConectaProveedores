using System;
using OutSystems.Application.RestConsume.Definitions;
using HttpMethod = OutSystems.Application.RestConsume.Definitions.HttpMethod;

namespace ssConectaProveedores;

public class UsersWithEmailActive_7db6eafc5f144aab8d78a3eb1ed8e854 : IRestConsumeApiMethod {
    public Guid Key { get; } = Guid.Parse("7db6eafc-5f14-4aab-8d78-a3eb1ed8e854");
    public string Name => "UsersWithEmailActive";
    public IRestConsumeApi RestConsumeApi { get; }
    public HttpMethod HttpMethod => HttpMethod.Post;
    public string UrlPath => "UsersWithEmailActive";
    public RequestFormat RequestFormat => OutSystems.Application.RestConsume.Definitions.RequestFormat.Json;
    public ResponseFormat ResponseFormat => OutSystems.Application.RestConsume.Definitions.ResponseFormat.Json;
    public IReadOnlyList<IRestConsumeApiMethodInputParameter> InputParameters { get; }
    public IReadOnlyList<IRestConsumeApiMethodOutputParameter> OutputParameters { get; }
    public TimeSpan? Timeout { get; } = null;

    public UsersWithEmailActive_7db6eafc5f144aab8d78a3eb1ed8e854(Notifications_90eca6e8b896426c930ac11800b3905c restConsumeApi) {
        RestConsumeApi = restConsumeApi;
        InputParameters = [
            new RestConsumeApiMethodInputParameter(Guid.Parse("7ea4ce4c-8aca-46f6-8b5a-6cb34190f167"), "users", this, false, ParameterType.Structure, new RestConsumeStructure_users2_06cbd1286b150e2e79c91e9d1ed3d811(),  true, ParameterSendIn.Body,null, true, null, MultipartPartSource.SingleStaticPart),

        ];

        OutputParameters = [
            new RestConsumeApiMethodOutputParameter(Guid.Parse("6474665b-3ce0-4220-b19e-90aaabf01332"), "Response", this, false, ParameterType.Structure, new RestConsumeStructure_APIOutput2_8509a484f6b6eac99c83feddd35d5004(), ParameterReceiveIn.Body, null),

        ];
    }
}