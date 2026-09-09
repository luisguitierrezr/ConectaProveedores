namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [ReferenceStructure] Environment (eiYB9M4Y4UCrfn+oPuwwBQ)
///  <code>ST_201dce7bb255178c132fec4d547942aeStructure</code> that represents <code>Environment</code
/// > <p>Description: Environment information</p>
/// </summary>
// Name: Environment
public partial struct ST_201dce7bb255178c132fec4d547942aeStructure : ITypedRecord<ST_201dce7bb255178c132fec4d547942aeStructure>, OutSystems.Application.Extensibility.DataTypes.IStructure {
internal static readonly GlobalObjectKey IdBaseURL = GlobalObjectKey.Parse("f4TRtbWntMqFXNtnZ7welw*gjbVBrJQT9sJpIowadVRqQ");
internal static readonly GlobalObjectKey IdLocale = GlobalObjectKey.Parse("f4TRtbWntMqFXNtnZ7welw*QUW8K7CaxaA5VFar_p3nkw");
internal static readonly GlobalObjectKey IdTimezone = GlobalObjectKey.Parse("f4TRtbWntMqFXNtnZ7welw*i4mGLDEdJJwM7qIjqLzp0Q");

public string ssBaseURL;

public string ssLocale;

public string ssTimezone;


public BitArray OptimizedAttributes;

public ST_201dce7bb255178c132fec4d547942aeStructure() {
OptimizedAttributes = null;
ssBaseURL = "";
ssLocale = "";
ssTimezone = "";
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[0];
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    }
}
get{
    BitArray[] all = new BitArray[0];
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssBaseURL = r.ReadText(index++, "Environment.BaseURL", "");
ssLocale = r.ReadText(index++, "Environment.Locale", "");
ssTimezone = r.ReadText(index++, "Environment.Timezone", "");
}
/// <summary>
/// Read from database
/// </summary>
/// <param name="r"> Data reader</param>
public void ReadDB( DbDataReader r) {
int index = 0;
Read(r, ref index);
}

/// <summary>
/// Read from record
/// </summary>
/// <param name="r"> Record</param>
public void ReadIM(ST_201dce7bb255178c132fec4d547942aeStructure r) {
this = r;
}


public static bool operator == (ST_201dce7bb255178c132fec4d547942aeStructure a, ST_201dce7bb255178c132fec4d547942aeStructure b) {
if (a.ssBaseURL != b.ssBaseURL) return false;
if (a.ssLocale != b.ssLocale) return false;
if (a.ssTimezone != b.ssTimezone) return false;
return true;
}

public static bool operator != (ST_201dce7bb255178c132fec4d547942aeStructure a, ST_201dce7bb255178c132fec4d547942aeStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_201dce7bb255178c132fec4d547942aeStructure)) return false;
return (this == (ST_201dce7bb255178c132fec4d547942aeStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssBaseURL.GetHashCode()
 ^ ssLocale.GetHashCode()
 ^ ssTimezone.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_201dce7bb255178c132fec4d547942aeStructure Duplicate() {
ST_201dce7bb255178c132fec4d547942aeStructure t;
t.ssBaseURL = this.ssBaseURL;
t.ssLocale = this.ssLocale;
t.ssTimezone = this.ssTimezone;
t.OptimizedAttributes = null;
return t;
}

IRecord IRecord.Duplicate() {
return Duplicate();
}

public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
throw new System.InvalidOperationException();
}

public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
String head = VarValue.GetHead(fields);
String tail = VarValue.GetTail(fields);
variable.Found = false;
if (head == "baseurl") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".BaseURL")) variable.Value = ssBaseURL; else variable.Optimized = true;
} else if (head == "locale") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Locale")) variable.Value = ssLocale; else variable.Optimized = true;
} else if (head == "timezone") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Timezone")) variable.Value = ssTimezone; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdBaseURL) {
return ssBaseURL;
}
if (key == IdLocale) {
return ssLocale;
}
if (key == IdTimezone) {
return ssTimezone;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdBaseURL.Key.AsGuid) {
return ssBaseURL;
}
if (attributeKey == IdLocale.Key.AsGuid) {
return ssLocale;
}
if (attributeKey == IdTimezone.Key.AsGuid) {
return ssTimezone;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssBaseURL = (string) other.AttributeGet(IdBaseURL);
ssLocale = (string) other.AttributeGet(IdLocale);
ssTimezone = (string) other.AttributeGet(IdTimezone);
}
public void CopyFrom(OutSystems.Application.Extensibility.DataTypes.IRecord other) {
if (other == null) return;
ssBaseURL = (string) other.GetAttribute(IdBaseURL.Key.AsGuid);
ssLocale = (string) other.GetAttribute(IdLocale.Key.AsGuid);
ssTimezone = (string) other.GetAttribute(IdTimezone.Key.AsGuid);
}
} // ST_201dce7bb255178c132fec4d547942aeStructure
/// <summary>
/// RecordList type <code>EnvironmentList</code> that represents a record list of
///  <code>Environment</code>
/// </summary>
public partial class RL_fcce2db859dfa6e2ca106a1132bdf294 : GenericRecordList<ST_201dce7bb255178c132fec4d547942aeStructure>, IEnumerable, IEnumerator {

protected override ST_201dce7bb255178c132fec4d547942aeStructure GetElementDefaultValue() {
return new ST_201dce7bb255178c132fec4d547942aeStructure();
}

public T[] ToArray<T>(Func<ST_201dce7bb255178c132fec4d547942aeStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_fcce2db859dfa6e2ca106a1132bdf294 recordList, Func<ST_201dce7bb255178c132fec4d547942aeStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_fcce2db859dfa6e2ca106a1132bdf294(ST_201dce7bb255178c132fec4d547942aeStructure[] array) {
  RL_fcce2db859dfa6e2ca106a1132bdf294 result = new RL_fcce2db859dfa6e2ca106a1132bdf294();
result.InnerFromArray(array);
    return result;
}

public static RL_fcce2db859dfa6e2ca106a1132bdf294 ToList<T>(T[] array, Func <T, ST_201dce7bb255178c132fec4d547942aeStructure> converter) {
  RL_fcce2db859dfa6e2ca106a1132bdf294 result = new RL_fcce2db859dfa6e2ca106a1132bdf294();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_fcce2db859dfa6e2ca106a1132bdf294 FromRestList<T>(RestList<T> restList, Func <T, ST_201dce7bb255178c132fec4d547942aeStructure> converter) {
  RL_fcce2db859dfa6e2ca106a1132bdf294 result = new RL_fcce2db859dfa6e2ca106a1132bdf294();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_fcce2db859dfa6e2ca106a1132bdf294() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_201dce7bb255178c132fec4d547942aeStructure> NewList() {
return new RL_fcce2db859dfa6e2ca106a1132bdf294();
}


} // RL_fcce2db859dfa6e2ca106a1132bdf294
}

