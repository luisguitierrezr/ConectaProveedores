using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// TextText_2Record
public class JSONRC_8a1c045009e7a849632ad52d45f16812 : AbstractRESTStructure<RC_8a1c045009e7a849632ad52d45f16812> {
[JsonProperty("Text")]
[JsonPropertyName("Text")]
public ssConectaProveedores.RestRecords.JSONST_1f76dfa138680efe9e5e11deb3c828b8Structure AttrText;

[JsonProperty("Text_2")]
[JsonPropertyName("Text_2")]
public ssConectaProveedores.RestRecords.JSONST_1f76dfa138680efe9e5e11deb3c828b8Structure AttrText_2;

public JSONRC_8a1c045009e7a849632ad52d45f16812() { }

public JSONRC_8a1c045009e7a849632ad52d45f16812 (RC_8a1c045009e7a849632ad52d45f16812 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrText = ConvertToRestWithoutDefaults(s.ssSTText, new ST_1f76dfa138680efe9e5e11deb3c828b8Structure(), ssConectaProveedores.RestRecords.JSONST_1f76dfa138680efe9e5e11deb3c828b8Structure.FromStructure, config);
AttrText_2 = ConvertToRestWithoutDefaults(s.ssSTText_2, new ST_1f76dfa138680efe9e5e11deb3c828b8Structure(), ssConectaProveedores.RestRecords.JSONST_1f76dfa138680efe9e5e11deb3c828b8Structure.FromStructure, config);
  } else {
AttrText = ssConectaProveedores.RestRecords.JSONST_1f76dfa138680efe9e5e11deb3c828b8Structure.FromStructure(s.ssSTText, config);
AttrText_2 = ssConectaProveedores.RestRecords.JSONST_1f76dfa138680efe9e5e11deb3c828b8Structure.FromStructure(s.ssSTText_2, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_8a1c045009e7a849632ad52d45f16812, RC_8a1c045009e7a849632ad52d45f16812> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_8a1c045009e7a849632ad52d45f16812 s) => ToStructure(s, config);
}
public static RC_8a1c045009e7a849632ad52d45f16812 ToStructure(ssConectaProveedores.RestRecords.JSONRC_8a1c045009e7a849632ad52d45f16812 obj, IBehaviorsConfiguration config) { 
  RC_8a1c045009e7a849632ad52d45f16812 s = new RC_8a1c045009e7a849632ad52d45f16812();
  if(obj != null) {
  s.ssSTText = ssConectaProveedores.RestRecords.JSONST_1f76dfa138680efe9e5e11deb3c828b8Structure.ToStructure(obj.AttrText, config);
  s.ssSTText_2 = ssConectaProveedores.RestRecords.JSONST_1f76dfa138680efe9e5e11deb3c828b8Structure.ToStructure(obj.AttrText_2, config);
  }
  return s;
}

public static Func<RC_8a1c045009e7a849632ad52d45f16812, ssConectaProveedores.RestRecords.JSONRC_8a1c045009e7a849632ad52d45f16812> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_8a1c045009e7a849632ad52d45f16812 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_8a1c045009e7a849632ad52d45f16812 FromStructure(RC_8a1c045009e7a849632ad52d45f16812 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_8a1c045009e7a849632ad52d45f16812(s, config);
}

}


