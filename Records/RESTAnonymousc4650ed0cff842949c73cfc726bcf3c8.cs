using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// EmailNotificationRecord
public class RESTRC_fc0c28a94f4c81220c2f7cc24e1f448a : AbstractRESTStructure<RC_fc0c28a94f4c81220c2f7cc24e1f448a> {
[JsonProperty("EmailNotification")]
public ssConectaProveedores.RestRecords.RESTST_12668886130225cd5b17c72a6562dd7cStructure AttrEmailNotification;

public RESTRC_fc0c28a94f4c81220c2f7cc24e1f448a() { }

public RESTRC_fc0c28a94f4c81220c2f7cc24e1f448a (RC_fc0c28a94f4c81220c2f7cc24e1f448a s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrEmailNotification = ConvertToRestWithoutDefaults(s.ssSTEmailNotification, new ST_12668886130225cd5b17c72a6562dd7cStructure(), ssConectaProveedores.RestRecords.RESTST_12668886130225cd5b17c72a6562dd7cStructure.FromStructure, config);
  } else {
AttrEmailNotification = ssConectaProveedores.RestRecords.RESTST_12668886130225cd5b17c72a6562dd7cStructure.FromStructure(s.ssSTEmailNotification, config);
  }
}

public static RC_fc0c28a94f4c81220c2f7cc24e1f448a ToStructure(ssConectaProveedores.RestRecords.RESTRC_fc0c28a94f4c81220c2f7cc24e1f448a obj) { 
  RC_fc0c28a94f4c81220c2f7cc24e1f448a s = new RC_fc0c28a94f4c81220c2f7cc24e1f448a();
  if(obj != null) {
  s.ssSTEmailNotification = ssConectaProveedores.RestRecords.RESTST_12668886130225cd5b17c72a6562dd7cStructure.ToStructure(obj.AttrEmailNotification);
  }
  return s;
}

public static Func<RC_fc0c28a94f4c81220c2f7cc24e1f448a, ssConectaProveedores.RestRecords.RESTRC_fc0c28a94f4c81220c2f7cc24e1f448a> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_fc0c28a94f4c81220c2f7cc24e1f448a s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_fc0c28a94f4c81220c2f7cc24e1f448a FromStructure(RC_fc0c28a94f4c81220c2f7cc24e1f448a s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_fc0c28a94f4c81220c2f7cc24e1f448a(s, config);
}

}


