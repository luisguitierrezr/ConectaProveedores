using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ProposalFileExtendedFile3Record
public class JSONRC_1ab3ef48680b2ecd9418ca5a547fee53 : AbstractRESTStructure<RC_1ab3ef48680b2ecd9418ca5a547fee53> {
[JsonProperty("Proposal")]
[JsonPropertyName("Proposal")]
public ssConectaProveedores.RestRecords.JSONEN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord AttrProposal;

[JsonProperty("FileExtended")]
[JsonPropertyName("FileExtended")]
public ssConectaProveedores.RestRecords.JSONEN_dcebdd8ba305133f41b1e1804925997fEntityRecord AttrFileExtended;

[JsonProperty("File3")]
[JsonPropertyName("File3")]
public ssConectaProveedores.RestRecords.JSONEN_1d38c6a5bdfe9befe9c6396896ed360eEntityRecord AttrFile3;

public JSONRC_1ab3ef48680b2ecd9418ca5a547fee53() { }

public JSONRC_1ab3ef48680b2ecd9418ca5a547fee53 (RC_1ab3ef48680b2ecd9418ca5a547fee53 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrProposal = ConvertToRestWithoutDefaults(s.ssENProposal, new EN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord.FromStructure, config);
AttrFileExtended = ConvertToRestWithoutDefaults(s.ssENFileExtended, new EN_dcebdd8ba305133f41b1e1804925997fEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_dcebdd8ba305133f41b1e1804925997fEntityRecord.FromStructure, config);
AttrFile3 = ConvertToRestWithoutDefaults(s.ssENFile3, new EN_1d38c6a5bdfe9befe9c6396896ed360eEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_1d38c6a5bdfe9befe9c6396896ed360eEntityRecord.FromStructure, config);
  } else {
AttrProposal = ssConectaProveedores.RestRecords.JSONEN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord.FromStructure(s.ssENProposal, config);
AttrFileExtended = ssConectaProveedores.RestRecords.JSONEN_dcebdd8ba305133f41b1e1804925997fEntityRecord.FromStructure(s.ssENFileExtended, config);
AttrFile3 = ssConectaProveedores.RestRecords.JSONEN_1d38c6a5bdfe9befe9c6396896ed360eEntityRecord.FromStructure(s.ssENFile3, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_1ab3ef48680b2ecd9418ca5a547fee53, RC_1ab3ef48680b2ecd9418ca5a547fee53> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_1ab3ef48680b2ecd9418ca5a547fee53 s) => ToStructure(s, config);
}
public static RC_1ab3ef48680b2ecd9418ca5a547fee53 ToStructure(ssConectaProveedores.RestRecords.JSONRC_1ab3ef48680b2ecd9418ca5a547fee53 obj, IBehaviorsConfiguration config) { 
  RC_1ab3ef48680b2ecd9418ca5a547fee53 s = new RC_1ab3ef48680b2ecd9418ca5a547fee53();
  if(obj != null) {
  s.ssENProposal = ssConectaProveedores.RestRecords.JSONEN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord.ToStructure(obj.AttrProposal, config);
  s.ssENFileExtended = ssConectaProveedores.RestRecords.JSONEN_dcebdd8ba305133f41b1e1804925997fEntityRecord.ToStructure(obj.AttrFileExtended, config);
  s.ssENFile3 = ssConectaProveedores.RestRecords.JSONEN_1d38c6a5bdfe9befe9c6396896ed360eEntityRecord.ToStructure(obj.AttrFile3, config);
  }
  return s;
}

public static Func<RC_1ab3ef48680b2ecd9418ca5a547fee53, ssConectaProveedores.RestRecords.JSONRC_1ab3ef48680b2ecd9418ca5a547fee53> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_1ab3ef48680b2ecd9418ca5a547fee53 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_1ab3ef48680b2ecd9418ca5a547fee53 FromStructure(RC_1ab3ef48680b2ecd9418ca5a547fee53 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_1ab3ef48680b2ecd9418ca5a547fee53(s, config);
}

}


