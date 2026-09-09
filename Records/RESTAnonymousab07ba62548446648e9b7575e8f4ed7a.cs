using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// MinuteDocumentTypeRecord
public class RESTRC_923bce1cc861aeec3c8146d26c567e1f : AbstractRESTStructure<RC_923bce1cc861aeec3c8146d26c567e1f> {
[JsonProperty("MinuteDocumentType")]
public ssConectaProveedores.RestRecords.RESTST_b2fd0f57faec93f17ef861f417f1cd5cStructure AttrMinuteDocumentType;

public RESTRC_923bce1cc861aeec3c8146d26c567e1f() { }

public RESTRC_923bce1cc861aeec3c8146d26c567e1f (RC_923bce1cc861aeec3c8146d26c567e1f s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrMinuteDocumentType = ConvertToRestWithoutDefaults(s.ssSTMinuteDocumentType, new ST_b2fd0f57faec93f17ef861f417f1cd5cStructure(), ssConectaProveedores.RestRecords.RESTST_b2fd0f57faec93f17ef861f417f1cd5cStructure.FromStructure, config);
  } else {
AttrMinuteDocumentType = ssConectaProveedores.RestRecords.RESTST_b2fd0f57faec93f17ef861f417f1cd5cStructure.FromStructure(s.ssSTMinuteDocumentType, config);
  }
}

public static RC_923bce1cc861aeec3c8146d26c567e1f ToStructure(ssConectaProveedores.RestRecords.RESTRC_923bce1cc861aeec3c8146d26c567e1f obj) { 
  RC_923bce1cc861aeec3c8146d26c567e1f s = new RC_923bce1cc861aeec3c8146d26c567e1f();
  if(obj != null) {
  s.ssSTMinuteDocumentType = ssConectaProveedores.RestRecords.RESTST_b2fd0f57faec93f17ef861f417f1cd5cStructure.ToStructure(obj.AttrMinuteDocumentType);
  }
  return s;
}

public static Func<RC_923bce1cc861aeec3c8146d26c567e1f, ssConectaProveedores.RestRecords.RESTRC_923bce1cc861aeec3c8146d26c567e1f> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_923bce1cc861aeec3c8146d26c567e1f s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_923bce1cc861aeec3c8146d26c567e1f FromStructure(RC_923bce1cc861aeec3c8146d26c567e1f s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_923bce1cc861aeec3c8146d26c567e1f(s, config);
}

}


