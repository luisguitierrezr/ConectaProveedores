using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// RoleStatusRecord
public class RESTRC_e6c76727dae2b3bb5ec75f08f3bfbb21 : AbstractRESTStructure<RC_e6c76727dae2b3bb5ec75f08f3bfbb21> {
[JsonProperty("RoleStatus")]
public ssConectaProveedores.RestRecords.RESTEN_fee44a96be32c0c9f1bda470eac56718EntityRecord AttrRoleStatus;

public RESTRC_e6c76727dae2b3bb5ec75f08f3bfbb21() { }

public RESTRC_e6c76727dae2b3bb5ec75f08f3bfbb21 (RC_e6c76727dae2b3bb5ec75f08f3bfbb21 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrRoleStatus = ConvertToRestWithoutDefaults(s.ssENRoleStatus, new EN_fee44a96be32c0c9f1bda470eac56718EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_fee44a96be32c0c9f1bda470eac56718EntityRecord.FromStructure, config);
  } else {
AttrRoleStatus = ssConectaProveedores.RestRecords.RESTEN_fee44a96be32c0c9f1bda470eac56718EntityRecord.FromStructure(s.ssENRoleStatus, config);
  }
}

public static RC_e6c76727dae2b3bb5ec75f08f3bfbb21 ToStructure(ssConectaProveedores.RestRecords.RESTRC_e6c76727dae2b3bb5ec75f08f3bfbb21 obj) { 
  RC_e6c76727dae2b3bb5ec75f08f3bfbb21 s = new RC_e6c76727dae2b3bb5ec75f08f3bfbb21();
  if(obj != null) {
  s.ssENRoleStatus = ssConectaProveedores.RestRecords.RESTEN_fee44a96be32c0c9f1bda470eac56718EntityRecord.ToStructure(obj.AttrRoleStatus);
  }
  return s;
}

public static Func<RC_e6c76727dae2b3bb5ec75f08f3bfbb21, ssConectaProveedores.RestRecords.RESTRC_e6c76727dae2b3bb5ec75f08f3bfbb21> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_e6c76727dae2b3bb5ec75f08f3bfbb21 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_e6c76727dae2b3bb5ec75f08f3bfbb21 FromStructure(RC_e6c76727dae2b3bb5ec75f08f3bfbb21 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_e6c76727dae2b3bb5ec75f08f3bfbb21(s, config);
}

}


