using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// DataPointRecord
public class RESTRC_87ab3d0b80938e4e95dcb616c8a9232e : AbstractRESTStructure<RC_87ab3d0b80938e4e95dcb616c8a9232e> {
[JsonProperty("DataPoint")]
public ssConectaProveedores.RestRecords.RESTST_34313c5cf94d7ce3c5404858c22fafd9Structure AttrDataPoint;

public RESTRC_87ab3d0b80938e4e95dcb616c8a9232e() { }

public RESTRC_87ab3d0b80938e4e95dcb616c8a9232e (RC_87ab3d0b80938e4e95dcb616c8a9232e s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrDataPoint = ConvertToRestWithoutDefaults(s.ssSTDataPoint, new ST_34313c5cf94d7ce3c5404858c22fafd9Structure(), ssConectaProveedores.RestRecords.RESTST_34313c5cf94d7ce3c5404858c22fafd9Structure.FromStructure, config);
  } else {
AttrDataPoint = ssConectaProveedores.RestRecords.RESTST_34313c5cf94d7ce3c5404858c22fafd9Structure.FromStructure(s.ssSTDataPoint, config);
  }
}

public static RC_87ab3d0b80938e4e95dcb616c8a9232e ToStructure(ssConectaProveedores.RestRecords.RESTRC_87ab3d0b80938e4e95dcb616c8a9232e obj) { 
  RC_87ab3d0b80938e4e95dcb616c8a9232e s = new RC_87ab3d0b80938e4e95dcb616c8a9232e();
  if(obj != null) {
  s.ssSTDataPoint = ssConectaProveedores.RestRecords.RESTST_34313c5cf94d7ce3c5404858c22fafd9Structure.ToStructure(obj.AttrDataPoint);
  }
  return s;
}

public static Func<RC_87ab3d0b80938e4e95dcb616c8a9232e, ssConectaProveedores.RestRecords.RESTRC_87ab3d0b80938e4e95dcb616c8a9232e> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_87ab3d0b80938e4e95dcb616c8a9232e s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_87ab3d0b80938e4e95dcb616c8a9232e FromStructure(RC_87ab3d0b80938e4e95dcb616c8a9232e s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_87ab3d0b80938e4e95dcb616c8a9232e(s, config);
}

}


