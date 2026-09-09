using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// EmailNotificationRecord
public class JSONRC_fc0c28a94f4c81220c2f7cc24e1f448a : AbstractRESTStructure<RC_fc0c28a94f4c81220c2f7cc24e1f448a> {
[JsonProperty("EmailNotification")]
[JsonPropertyName("EmailNotification")]
public ssConectaProveedores.RestRecords.JSONST_12668886130225cd5b17c72a6562dd7cStructure AttrEmailNotification;

public JSONRC_fc0c28a94f4c81220c2f7cc24e1f448a() { }

public JSONRC_fc0c28a94f4c81220c2f7cc24e1f448a (RC_fc0c28a94f4c81220c2f7cc24e1f448a s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrEmailNotification = ConvertToRestWithoutDefaults(s.ssSTEmailNotification, new ST_12668886130225cd5b17c72a6562dd7cStructure(), ssConectaProveedores.RestRecords.JSONST_12668886130225cd5b17c72a6562dd7cStructure.FromStructure, config);
  } else {
AttrEmailNotification = ssConectaProveedores.RestRecords.JSONST_12668886130225cd5b17c72a6562dd7cStructure.FromStructure(s.ssSTEmailNotification, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_fc0c28a94f4c81220c2f7cc24e1f448a, RC_fc0c28a94f4c81220c2f7cc24e1f448a> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_fc0c28a94f4c81220c2f7cc24e1f448a s) => ToStructure(s, config);
}
public static RC_fc0c28a94f4c81220c2f7cc24e1f448a ToStructure(ssConectaProveedores.RestRecords.JSONRC_fc0c28a94f4c81220c2f7cc24e1f448a obj, IBehaviorsConfiguration config) { 
  RC_fc0c28a94f4c81220c2f7cc24e1f448a s = new RC_fc0c28a94f4c81220c2f7cc24e1f448a();
  if(obj != null) {
  s.ssSTEmailNotification = ssConectaProveedores.RestRecords.JSONST_12668886130225cd5b17c72a6562dd7cStructure.ToStructure(obj.AttrEmailNotification, config);
  }
  return s;
}

public static Func<RC_fc0c28a94f4c81220c2f7cc24e1f448a, ssConectaProveedores.RestRecords.JSONRC_fc0c28a94f4c81220c2f7cc24e1f448a> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_fc0c28a94f4c81220c2f7cc24e1f448a s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_fc0c28a94f4c81220c2f7cc24e1f448a FromStructure(RC_fc0c28a94f4c81220c2f7cc24e1f448a s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_fc0c28a94f4c81220c2f7cc24e1f448a(s, config);
}

}


