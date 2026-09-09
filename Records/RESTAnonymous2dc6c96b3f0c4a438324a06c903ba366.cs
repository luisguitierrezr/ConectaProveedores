using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// EmailNotifTesorariaRecord
public class RESTRC_a9c222d16d2a5710a4b4eb27d615bc5d : AbstractRESTStructure<RC_a9c222d16d2a5710a4b4eb27d615bc5d> {
[JsonProperty("EmailNotifTesoraria")]
public ssConectaProveedores.RestRecords.RESTST_b97a22be0cf9a9b2c6ab22fc6bcd3c6dStructure AttrEmailNotifTesoraria;

public RESTRC_a9c222d16d2a5710a4b4eb27d615bc5d() { }

public RESTRC_a9c222d16d2a5710a4b4eb27d615bc5d (RC_a9c222d16d2a5710a4b4eb27d615bc5d s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrEmailNotifTesoraria = ConvertToRestWithoutDefaults(s.ssSTEmailNotifTesoraria, new ST_b97a22be0cf9a9b2c6ab22fc6bcd3c6dStructure(), ssConectaProveedores.RestRecords.RESTST_b97a22be0cf9a9b2c6ab22fc6bcd3c6dStructure.FromStructure, config);
  } else {
AttrEmailNotifTesoraria = ssConectaProveedores.RestRecords.RESTST_b97a22be0cf9a9b2c6ab22fc6bcd3c6dStructure.FromStructure(s.ssSTEmailNotifTesoraria, config);
  }
}

public static RC_a9c222d16d2a5710a4b4eb27d615bc5d ToStructure(ssConectaProveedores.RestRecords.RESTRC_a9c222d16d2a5710a4b4eb27d615bc5d obj) { 
  RC_a9c222d16d2a5710a4b4eb27d615bc5d s = new RC_a9c222d16d2a5710a4b4eb27d615bc5d();
  if(obj != null) {
  s.ssSTEmailNotifTesoraria = ssConectaProveedores.RestRecords.RESTST_b97a22be0cf9a9b2c6ab22fc6bcd3c6dStructure.ToStructure(obj.AttrEmailNotifTesoraria);
  }
  return s;
}

public static Func<RC_a9c222d16d2a5710a4b4eb27d615bc5d, ssConectaProveedores.RestRecords.RESTRC_a9c222d16d2a5710a4b4eb27d615bc5d> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_a9c222d16d2a5710a4b4eb27d615bc5d s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_a9c222d16d2a5710a4b4eb27d615bc5d FromStructure(RC_a9c222d16d2a5710a4b4eb27d615bc5d s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_a9c222d16d2a5710a4b4eb27d615bc5d(s, config);
}

}


