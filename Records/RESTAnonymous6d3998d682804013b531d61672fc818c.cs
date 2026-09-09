using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// RequisitionContractFileForeignResidenceRequisitionFile2ForeignResidenceRecord
public class RESTRC_ac566b5b63768f933fd7207ce4399046 : AbstractRESTStructure<RC_ac566b5b63768f933fd7207ce4399046> {
[JsonProperty("RequisitionContractFileForeignResidence")]
public ssConectaProveedores.RestRecords.RESTEN_aeab0089a9236dfc6c684ea98f650647EntityRecord AttrRequisitionContractFileForeignResidence;

[JsonProperty("RequisitionFile2ForeignResidence")]
public ssConectaProveedores.RestRecords.RESTEN_4cce425e15647f937e21de4e52849889EntityRecord AttrRequisitionFile2ForeignResidence;

public RESTRC_ac566b5b63768f933fd7207ce4399046() { }

public RESTRC_ac566b5b63768f933fd7207ce4399046 (RC_ac566b5b63768f933fd7207ce4399046 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrRequisitionContractFileForeignResidence = ConvertToRestWithoutDefaults(s.ssENRequisitionContractFileForeignResidence, new EN_aeab0089a9236dfc6c684ea98f650647EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_aeab0089a9236dfc6c684ea98f650647EntityRecord.FromStructure, config);
AttrRequisitionFile2ForeignResidence = ConvertToRestWithoutDefaults(s.ssENRequisitionFile2ForeignResidence, new EN_4cce425e15647f937e21de4e52849889EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_4cce425e15647f937e21de4e52849889EntityRecord.FromStructure, config);
  } else {
AttrRequisitionContractFileForeignResidence = ssConectaProveedores.RestRecords.RESTEN_aeab0089a9236dfc6c684ea98f650647EntityRecord.FromStructure(s.ssENRequisitionContractFileForeignResidence, config);
AttrRequisitionFile2ForeignResidence = ssConectaProveedores.RestRecords.RESTEN_4cce425e15647f937e21de4e52849889EntityRecord.FromStructure(s.ssENRequisitionFile2ForeignResidence, config);
  }
}

public static RC_ac566b5b63768f933fd7207ce4399046 ToStructure(ssConectaProveedores.RestRecords.RESTRC_ac566b5b63768f933fd7207ce4399046 obj) { 
  RC_ac566b5b63768f933fd7207ce4399046 s = new RC_ac566b5b63768f933fd7207ce4399046();
  if(obj != null) {
  s.ssENRequisitionContractFileForeignResidence = ssConectaProveedores.RestRecords.RESTEN_aeab0089a9236dfc6c684ea98f650647EntityRecord.ToStructure(obj.AttrRequisitionContractFileForeignResidence);
  s.ssENRequisitionFile2ForeignResidence = ssConectaProveedores.RestRecords.RESTEN_4cce425e15647f937e21de4e52849889EntityRecord.ToStructure(obj.AttrRequisitionFile2ForeignResidence);
  }
  return s;
}

public static Func<RC_ac566b5b63768f933fd7207ce4399046, ssConectaProveedores.RestRecords.RESTRC_ac566b5b63768f933fd7207ce4399046> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_ac566b5b63768f933fd7207ce4399046 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_ac566b5b63768f933fd7207ce4399046 FromStructure(RC_ac566b5b63768f933fd7207ce4399046 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_ac566b5b63768f933fd7207ce4399046(s, config);
}

}


