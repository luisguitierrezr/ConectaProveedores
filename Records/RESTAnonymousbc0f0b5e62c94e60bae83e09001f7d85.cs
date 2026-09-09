using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// RequisitionFile2Record
public class RESTRC_3e0fb635eefe948054fa75421546a901 : AbstractRESTStructure<RC_3e0fb635eefe948054fa75421546a901> {
[JsonProperty("RequisitionFile2")]
public ssConectaProveedores.RestRecords.RESTEN_4cce425e15647f937e21de4e52849889EntityRecord AttrRequisitionFile2;

public RESTRC_3e0fb635eefe948054fa75421546a901() { }

public RESTRC_3e0fb635eefe948054fa75421546a901 (RC_3e0fb635eefe948054fa75421546a901 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrRequisitionFile2 = ConvertToRestWithoutDefaults(s.ssENRequisitionFile2, new EN_4cce425e15647f937e21de4e52849889EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_4cce425e15647f937e21de4e52849889EntityRecord.FromStructure, config);
  } else {
AttrRequisitionFile2 = ssConectaProveedores.RestRecords.RESTEN_4cce425e15647f937e21de4e52849889EntityRecord.FromStructure(s.ssENRequisitionFile2, config);
  }
}

public static RC_3e0fb635eefe948054fa75421546a901 ToStructure(ssConectaProveedores.RestRecords.RESTRC_3e0fb635eefe948054fa75421546a901 obj) { 
  RC_3e0fb635eefe948054fa75421546a901 s = new RC_3e0fb635eefe948054fa75421546a901();
  if(obj != null) {
  s.ssENRequisitionFile2 = ssConectaProveedores.RestRecords.RESTEN_4cce425e15647f937e21de4e52849889EntityRecord.ToStructure(obj.AttrRequisitionFile2);
  }
  return s;
}

public static Func<RC_3e0fb635eefe948054fa75421546a901, ssConectaProveedores.RestRecords.RESTRC_3e0fb635eefe948054fa75421546a901> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_3e0fb635eefe948054fa75421546a901 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_3e0fb635eefe948054fa75421546a901 FromStructure(RC_3e0fb635eefe948054fa75421546a901 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_3e0fb635eefe948054fa75421546a901(s, config);
}

}


