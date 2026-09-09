using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// EmailNotifTesorariaRecord
public class JSONRC_a9c222d16d2a5710a4b4eb27d615bc5d : AbstractRESTStructure<RC_a9c222d16d2a5710a4b4eb27d615bc5d> {
[JsonProperty("EmailNotifTesoraria")]
[JsonPropertyName("EmailNotifTesoraria")]
public ssConectaProveedores.RestRecords.JSONST_b97a22be0cf9a9b2c6ab22fc6bcd3c6dStructure AttrEmailNotifTesoraria;

public JSONRC_a9c222d16d2a5710a4b4eb27d615bc5d() { }

public JSONRC_a9c222d16d2a5710a4b4eb27d615bc5d (RC_a9c222d16d2a5710a4b4eb27d615bc5d s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrEmailNotifTesoraria = ConvertToRestWithoutDefaults(s.ssSTEmailNotifTesoraria, new ST_b97a22be0cf9a9b2c6ab22fc6bcd3c6dStructure(), ssConectaProveedores.RestRecords.JSONST_b97a22be0cf9a9b2c6ab22fc6bcd3c6dStructure.FromStructure, config);
  } else {
AttrEmailNotifTesoraria = ssConectaProveedores.RestRecords.JSONST_b97a22be0cf9a9b2c6ab22fc6bcd3c6dStructure.FromStructure(s.ssSTEmailNotifTesoraria, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_a9c222d16d2a5710a4b4eb27d615bc5d, RC_a9c222d16d2a5710a4b4eb27d615bc5d> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_a9c222d16d2a5710a4b4eb27d615bc5d s) => ToStructure(s, config);
}
public static RC_a9c222d16d2a5710a4b4eb27d615bc5d ToStructure(ssConectaProveedores.RestRecords.JSONRC_a9c222d16d2a5710a4b4eb27d615bc5d obj, IBehaviorsConfiguration config) { 
  RC_a9c222d16d2a5710a4b4eb27d615bc5d s = new RC_a9c222d16d2a5710a4b4eb27d615bc5d();
  if(obj != null) {
  s.ssSTEmailNotifTesoraria = ssConectaProveedores.RestRecords.JSONST_b97a22be0cf9a9b2c6ab22fc6bcd3c6dStructure.ToStructure(obj.AttrEmailNotifTesoraria, config);
  }
  return s;
}

public static Func<RC_a9c222d16d2a5710a4b4eb27d615bc5d, ssConectaProveedores.RestRecords.JSONRC_a9c222d16d2a5710a4b4eb27d615bc5d> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_a9c222d16d2a5710a4b4eb27d615bc5d s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_a9c222d16d2a5710a4b4eb27d615bc5d FromStructure(RC_a9c222d16d2a5710a4b4eb27d615bc5d s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_a9c222d16d2a5710a4b4eb27d615bc5d(s, config);
}

}


