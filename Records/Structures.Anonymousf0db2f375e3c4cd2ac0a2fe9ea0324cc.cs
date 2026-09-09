namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (Ny_b8Dxe0kysCi_p6gMkzA)
///  <code>RC_65a6cd6541355f3cc5923c05ddee6119</code> that represent
/// s <code>CustomSettingsCustomSettingValueRecord</code> <p>Description: </p>
/// </summary>
// Name: CustomSettingsCustomSettingValueRecord
public partial struct RC_65a6cd6541355f3cc5923c05ddee6119 : ITypedRecord<RC_65a6cd6541355f3cc5923c05ddee6119> {
internal static readonly GlobalObjectKey IdCustomSettings = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*1GjqTG+kc71y1PGB6Yv82w");
internal static readonly GlobalObjectKey IdCustomSettingValue = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Ymb1_h3G_XotPJDl9Jz8+g");

public EN_2598b425876f6271c300c0879185e230EntityRecord ssENCustomSettings;

public EN_ed4c8de87f39a0c4c5e65b9db53df136EntityRecord ssENCustomSettingValue;


public BitArray OptimizedAttributes;

public RC_65a6cd6541355f3cc5923c05ddee6119() {
OptimizedAttributes = null;
ssENCustomSettings = new EN_2598b425876f6271c300c0879185e230EntityRecord();
ssENCustomSettingValue = new EN_ed4c8de87f39a0c4c5e65b9db53df136EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[2];
    all[0] = new BitArray(6,false);
    all[1] = new BitArray(5,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENCustomSettings.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENCustomSettingValue.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    }else{
    ssENCustomSettings.OptimizedAttributes = value[0];
    ssENCustomSettingValue.OptimizedAttributes = value[1];
    }
}
get{
    BitArray[] all = new BitArray[2];
    all[0] = ssENCustomSettings.OptimizedAttributes;
    all[1] = ssENCustomSettingValue.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENCustomSettings.Read( r, ref index);
ssENCustomSettingValue.Read( r, ref index);
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
public void ReadIM(RC_65a6cd6541355f3cc5923c05ddee6119 r) {
this = r;
}


public static bool operator == (RC_65a6cd6541355f3cc5923c05ddee6119 a, RC_65a6cd6541355f3cc5923c05ddee6119 b) {
if (a.ssENCustomSettings != b.ssENCustomSettings) return false;
if (a.ssENCustomSettingValue != b.ssENCustomSettingValue) return false;
return true;
}

public static bool operator != (RC_65a6cd6541355f3cc5923c05ddee6119 a, RC_65a6cd6541355f3cc5923c05ddee6119 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_65a6cd6541355f3cc5923c05ddee6119)) return false;
return (this == (RC_65a6cd6541355f3cc5923c05ddee6119)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENCustomSettings.GetHashCode()
 ^ ssENCustomSettingValue.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENCustomSettings.RecursiveReset();
ssENCustomSettingValue.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENCustomSettings.InternalRecursiveSave();
ssENCustomSettingValue.InternalRecursiveSave();
}


public RC_65a6cd6541355f3cc5923c05ddee6119 Duplicate() {
RC_65a6cd6541355f3cc5923c05ddee6119 t;
t.ssENCustomSettings = (EN_2598b425876f6271c300c0879185e230EntityRecord)this.ssENCustomSettings.Duplicate();
t.ssENCustomSettingValue = (EN_ed4c8de87f39a0c4c5e65b9db53df136EntityRecord)this.ssENCustomSettingValue.Duplicate();
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
if (head == "customsettings") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CustomSettings")) variable.Value = ssENCustomSettings; else variable.Optimized = true;
variable.SetFieldName("customsettings");
} else if (head == "customsettingvalue") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CustomSettingValue")) variable.Value = ssENCustomSettingValue; else variable.Optimized = true;
variable.SetFieldName("customsettingvalue");
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
if (key == IdCustomSettings) {
return ssENCustomSettings;
}
if (key == IdCustomSettingValue) {
return ssENCustomSettingValue;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdCustomSettings.Key.AsGuid) {
return ssENCustomSettings;
}
if (attributeKey == IdCustomSettingValue.Key.AsGuid) {
return ssENCustomSettingValue;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENCustomSettings.FillFromOther((IRecord) other.AttributeGet(IdCustomSettings));
ssENCustomSettingValue.FillFromOther((IRecord) other.AttributeGet(IdCustomSettingValue));
}
} // RC_65a6cd6541355f3cc5923c05ddee6119
/// <summary>
/// RecordList type <code>CustomSettingsCustomSettingValueRecordList</code> that represents a record
///  list of <code>CustomSettings, CustomSettingValue</code>
/// </summary>
public partial class RL_03472b0ba33e12fef4eae9e97dce9a76 : GenericRecordList<RC_65a6cd6541355f3cc5923c05ddee6119>, IEnumerable, IEnumerator {

protected override RC_65a6cd6541355f3cc5923c05ddee6119 GetElementDefaultValue() {
return new RC_65a6cd6541355f3cc5923c05ddee6119();
}

public T[] ToArray<T>(Func<RC_65a6cd6541355f3cc5923c05ddee6119, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_03472b0ba33e12fef4eae9e97dce9a76 recordList, Func<RC_65a6cd6541355f3cc5923c05ddee6119, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_03472b0ba33e12fef4eae9e97dce9a76(RC_65a6cd6541355f3cc5923c05ddee6119[] array) {
  RL_03472b0ba33e12fef4eae9e97dce9a76 result = new RL_03472b0ba33e12fef4eae9e97dce9a76();
result.InnerFromArray(array);
    return result;
}

public static RL_03472b0ba33e12fef4eae9e97dce9a76 ToList<T>(T[] array, Func <T, RC_65a6cd6541355f3cc5923c05ddee6119> converter) {
  RL_03472b0ba33e12fef4eae9e97dce9a76 result = new RL_03472b0ba33e12fef4eae9e97dce9a76();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_03472b0ba33e12fef4eae9e97dce9a76 FromRestList<T>(RestList<T> restList, Func <T, RC_65a6cd6541355f3cc5923c05ddee6119> converter) {
  RL_03472b0ba33e12fef4eae9e97dce9a76 result = new RL_03472b0ba33e12fef4eae9e97dce9a76();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_03472b0ba33e12fef4eae9e97dce9a76() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[2];
def[0] = new BitArray(6,false);
def[1] = new BitArray(5,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_65a6cd6541355f3cc5923c05ddee6119> NewList() {
return new RL_03472b0ba33e12fef4eae9e97dce9a76();
}


} // RL_03472b0ba33e12fef4eae9e97dce9a76
}

