using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderApprovalRecord
public class RESTRC_51831f8bbf408689b196be5dba3a91ea : AbstractRESTStructure<RC_51831f8bbf408689b196be5dba3a91ea> {
[JsonProperty("OrderApproval")]
public ssConectaProveedores.RestRecords.RESTEN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord AttrOrderApproval;

public RESTRC_51831f8bbf408689b196be5dba3a91ea() { }

public RESTRC_51831f8bbf408689b196be5dba3a91ea (RC_51831f8bbf408689b196be5dba3a91ea s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderApproval = ConvertToRestWithoutDefaults(s.ssENOrderApproval, new EN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord.FromStructure, config);
  } else {
AttrOrderApproval = ssConectaProveedores.RestRecords.RESTEN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord.FromStructure(s.ssENOrderApproval, config);
  }
}

public static RC_51831f8bbf408689b196be5dba3a91ea ToStructure(ssConectaProveedores.RestRecords.RESTRC_51831f8bbf408689b196be5dba3a91ea obj) { 
  RC_51831f8bbf408689b196be5dba3a91ea s = new RC_51831f8bbf408689b196be5dba3a91ea();
  if(obj != null) {
  s.ssENOrderApproval = ssConectaProveedores.RestRecords.RESTEN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord.ToStructure(obj.AttrOrderApproval);
  }
  return s;
}

public static Func<RC_51831f8bbf408689b196be5dba3a91ea, ssConectaProveedores.RestRecords.RESTRC_51831f8bbf408689b196be5dba3a91ea> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_51831f8bbf408689b196be5dba3a91ea s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_51831f8bbf408689b196be5dba3a91ea FromStructure(RC_51831f8bbf408689b196be5dba3a91ea s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_51831f8bbf408689b196be5dba3a91ea(s, config);
}

}


