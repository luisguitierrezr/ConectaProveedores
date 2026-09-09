using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// RequisitionContractFileRequisitionFile2Record
public class RESTRC_dc345357879dcb92e41eacae4ac8926c : AbstractRESTStructure<RC_dc345357879dcb92e41eacae4ac8926c> {
[JsonProperty("RequisitionContractFile")]
public ssConectaProveedores.RestRecords.RESTEN_aeab0089a9236dfc6c684ea98f650647EntityRecord AttrRequisitionContractFile;

[JsonProperty("RequisitionFile2")]
public ssConectaProveedores.RestRecords.RESTEN_4cce425e15647f937e21de4e52849889EntityRecord AttrRequisitionFile2;

public RESTRC_dc345357879dcb92e41eacae4ac8926c() { }

public RESTRC_dc345357879dcb92e41eacae4ac8926c (RC_dc345357879dcb92e41eacae4ac8926c s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrRequisitionContractFile = ConvertToRestWithoutDefaults(s.ssENRequisitionContractFile, new EN_aeab0089a9236dfc6c684ea98f650647EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_aeab0089a9236dfc6c684ea98f650647EntityRecord.FromStructure, config);
AttrRequisitionFile2 = ConvertToRestWithoutDefaults(s.ssENRequisitionFile2, new EN_4cce425e15647f937e21de4e52849889EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_4cce425e15647f937e21de4e52849889EntityRecord.FromStructure, config);
  } else {
AttrRequisitionContractFile = ssConectaProveedores.RestRecords.RESTEN_aeab0089a9236dfc6c684ea98f650647EntityRecord.FromStructure(s.ssENRequisitionContractFile, config);
AttrRequisitionFile2 = ssConectaProveedores.RestRecords.RESTEN_4cce425e15647f937e21de4e52849889EntityRecord.FromStructure(s.ssENRequisitionFile2, config);
  }
}

public static RC_dc345357879dcb92e41eacae4ac8926c ToStructure(ssConectaProveedores.RestRecords.RESTRC_dc345357879dcb92e41eacae4ac8926c obj) { 
  RC_dc345357879dcb92e41eacae4ac8926c s = new RC_dc345357879dcb92e41eacae4ac8926c();
  if(obj != null) {
  s.ssENRequisitionContractFile = ssConectaProveedores.RestRecords.RESTEN_aeab0089a9236dfc6c684ea98f650647EntityRecord.ToStructure(obj.AttrRequisitionContractFile);
  s.ssENRequisitionFile2 = ssConectaProveedores.RestRecords.RESTEN_4cce425e15647f937e21de4e52849889EntityRecord.ToStructure(obj.AttrRequisitionFile2);
  }
  return s;
}

public static Func<RC_dc345357879dcb92e41eacae4ac8926c, ssConectaProveedores.RestRecords.RESTRC_dc345357879dcb92e41eacae4ac8926c> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_dc345357879dcb92e41eacae4ac8926c s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_dc345357879dcb92e41eacae4ac8926c FromStructure(RC_dc345357879dcb92e41eacae4ac8926c s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_dc345357879dcb92e41eacae4ac8926c(s, config);
}

}


