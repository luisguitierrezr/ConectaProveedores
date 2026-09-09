using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// MinuteDocumentTypeRecord
public class JSONRC_923bce1cc861aeec3c8146d26c567e1f : AbstractRESTStructure<RC_923bce1cc861aeec3c8146d26c567e1f> {
[JsonProperty("MinuteDocumentType")]
[JsonPropertyName("MinuteDocumentType")]
public ssConectaProveedores.RestRecords.JSONST_b2fd0f57faec93f17ef861f417f1cd5cStructure AttrMinuteDocumentType;

public JSONRC_923bce1cc861aeec3c8146d26c567e1f() { }

public JSONRC_923bce1cc861aeec3c8146d26c567e1f (RC_923bce1cc861aeec3c8146d26c567e1f s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrMinuteDocumentType = ConvertToRestWithoutDefaults(s.ssSTMinuteDocumentType, new ST_b2fd0f57faec93f17ef861f417f1cd5cStructure(), ssConectaProveedores.RestRecords.JSONST_b2fd0f57faec93f17ef861f417f1cd5cStructure.FromStructure, config);
  } else {
AttrMinuteDocumentType = ssConectaProveedores.RestRecords.JSONST_b2fd0f57faec93f17ef861f417f1cd5cStructure.FromStructure(s.ssSTMinuteDocumentType, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_923bce1cc861aeec3c8146d26c567e1f, RC_923bce1cc861aeec3c8146d26c567e1f> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_923bce1cc861aeec3c8146d26c567e1f s) => ToStructure(s, config);
}
public static RC_923bce1cc861aeec3c8146d26c567e1f ToStructure(ssConectaProveedores.RestRecords.JSONRC_923bce1cc861aeec3c8146d26c567e1f obj, IBehaviorsConfiguration config) { 
  RC_923bce1cc861aeec3c8146d26c567e1f s = new RC_923bce1cc861aeec3c8146d26c567e1f();
  if(obj != null) {
  s.ssSTMinuteDocumentType = ssConectaProveedores.RestRecords.JSONST_b2fd0f57faec93f17ef861f417f1cd5cStructure.ToStructure(obj.AttrMinuteDocumentType, config);
  }
  return s;
}

public static Func<RC_923bce1cc861aeec3c8146d26c567e1f, ssConectaProveedores.RestRecords.JSONRC_923bce1cc861aeec3c8146d26c567e1f> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_923bce1cc861aeec3c8146d26c567e1f s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_923bce1cc861aeec3c8146d26c567e1f FromStructure(RC_923bce1cc861aeec3c8146d26c567e1f s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_923bce1cc861aeec3c8146d26c567e1f(s, config);
}

}


