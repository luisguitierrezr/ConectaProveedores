using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// GutterSizeRecord
public class JSONRC_a5018402fa6c90c5e826e54b2748cedc : AbstractRESTStructure<RC_a5018402fa6c90c5e826e54b2748cedc> {
[JsonProperty("GutterSize")]
[JsonPropertyName("GutterSize")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_48a3ab8db598b5be6bef9add20e71bbbEntityRecord AttrGutterSize;

public JSONRC_a5018402fa6c90c5e826e54b2748cedc() { }

public JSONRC_a5018402fa6c90c5e826e54b2748cedc (RC_a5018402fa6c90c5e826e54b2748cedc s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrGutterSize = ConvertToRestWithoutDefaults(s.ssENGutterSize, new EN_48a3ab8db598b5be6bef9add20e71bbbEntityRecord(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_48a3ab8db598b5be6bef9add20e71bbbEntityRecord.FromStructure, config);
  } else {
AttrGutterSize = ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_48a3ab8db598b5be6bef9add20e71bbbEntityRecord.FromStructure(s.ssENGutterSize, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_a5018402fa6c90c5e826e54b2748cedc, RC_a5018402fa6c90c5e826e54b2748cedc> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_a5018402fa6c90c5e826e54b2748cedc s) => ToStructure(s, config);
}
public static RC_a5018402fa6c90c5e826e54b2748cedc ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_a5018402fa6c90c5e826e54b2748cedc obj, IBehaviorsConfiguration config) { 
  RC_a5018402fa6c90c5e826e54b2748cedc s = new RC_a5018402fa6c90c5e826e54b2748cedc();
  if(obj != null) {
  s.ssENGutterSize = ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_48a3ab8db598b5be6bef9add20e71bbbEntityRecord.ToStructure(obj.AttrGutterSize, config);
  }
  return s;
}

public static Func<RC_a5018402fa6c90c5e826e54b2748cedc, ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_a5018402fa6c90c5e826e54b2748cedc> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_a5018402fa6c90c5e826e54b2748cedc s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_a5018402fa6c90c5e826e54b2748cedc FromStructure(RC_a5018402fa6c90c5e826e54b2748cedc s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_a5018402fa6c90c5e826e54b2748cedc(s, config);
}

}


