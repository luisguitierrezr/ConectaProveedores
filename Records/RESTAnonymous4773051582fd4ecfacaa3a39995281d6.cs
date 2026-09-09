using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// RequisitionCostCenterRecord
public class RESTRC_508355980a3676af946819914b6b1546 : AbstractRESTStructure<RC_508355980a3676af946819914b6b1546> {
[JsonProperty("RequisitionCostCenter")]
public ssConectaProveedores.RestRecords.RESTEN_114fcf95674648310a3efb0d78529a37EntityRecord AttrRequisitionCostCenter;

public RESTRC_508355980a3676af946819914b6b1546() { }

public RESTRC_508355980a3676af946819914b6b1546 (RC_508355980a3676af946819914b6b1546 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrRequisitionCostCenter = ConvertToRestWithoutDefaults(s.ssENRequisitionCostCenter, new EN_114fcf95674648310a3efb0d78529a37EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_114fcf95674648310a3efb0d78529a37EntityRecord.FromStructure, config);
  } else {
AttrRequisitionCostCenter = ssConectaProveedores.RestRecords.RESTEN_114fcf95674648310a3efb0d78529a37EntityRecord.FromStructure(s.ssENRequisitionCostCenter, config);
  }
}

public static RC_508355980a3676af946819914b6b1546 ToStructure(ssConectaProveedores.RestRecords.RESTRC_508355980a3676af946819914b6b1546 obj) { 
  RC_508355980a3676af946819914b6b1546 s = new RC_508355980a3676af946819914b6b1546();
  if(obj != null) {
  s.ssENRequisitionCostCenter = ssConectaProveedores.RestRecords.RESTEN_114fcf95674648310a3efb0d78529a37EntityRecord.ToStructure(obj.AttrRequisitionCostCenter);
  }
  return s;
}

public static Func<RC_508355980a3676af946819914b6b1546, ssConectaProveedores.RestRecords.RESTRC_508355980a3676af946819914b6b1546> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_508355980a3676af946819914b6b1546 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_508355980a3676af946819914b6b1546 FromStructure(RC_508355980a3676af946819914b6b1546 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_508355980a3676af946819914b6b1546(s, config);
}

}


