using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderApprovalRecord
public class JSONRC_51831f8bbf408689b196be5dba3a91ea : AbstractRESTStructure<RC_51831f8bbf408689b196be5dba3a91ea> {
[JsonProperty("OrderApproval")]
[JsonPropertyName("OrderApproval")]
public ssConectaProveedores.RestRecords.JSONEN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord AttrOrderApproval;

public JSONRC_51831f8bbf408689b196be5dba3a91ea() { }

public JSONRC_51831f8bbf408689b196be5dba3a91ea (RC_51831f8bbf408689b196be5dba3a91ea s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderApproval = ConvertToRestWithoutDefaults(s.ssENOrderApproval, new EN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord.FromStructure, config);
  } else {
AttrOrderApproval = ssConectaProveedores.RestRecords.JSONEN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord.FromStructure(s.ssENOrderApproval, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_51831f8bbf408689b196be5dba3a91ea, RC_51831f8bbf408689b196be5dba3a91ea> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_51831f8bbf408689b196be5dba3a91ea s) => ToStructure(s, config);
}
public static RC_51831f8bbf408689b196be5dba3a91ea ToStructure(ssConectaProveedores.RestRecords.JSONRC_51831f8bbf408689b196be5dba3a91ea obj, IBehaviorsConfiguration config) { 
  RC_51831f8bbf408689b196be5dba3a91ea s = new RC_51831f8bbf408689b196be5dba3a91ea();
  if(obj != null) {
  s.ssENOrderApproval = ssConectaProveedores.RestRecords.JSONEN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord.ToStructure(obj.AttrOrderApproval, config);
  }
  return s;
}

public static Func<RC_51831f8bbf408689b196be5dba3a91ea, ssConectaProveedores.RestRecords.JSONRC_51831f8bbf408689b196be5dba3a91ea> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_51831f8bbf408689b196be5dba3a91ea s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_51831f8bbf408689b196be5dba3a91ea FromStructure(RC_51831f8bbf408689b196be5dba3a91ea s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_51831f8bbf408689b196be5dba3a91ea(s, config);
}

}


