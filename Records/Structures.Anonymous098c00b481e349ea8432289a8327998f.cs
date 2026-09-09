namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (tACMCeOB6kmEMiiagyeZjw)
///  <code>RC_fef56662c61d7afd2d3c90e5f49cfcfa</code> that represent
/// s <code>CustomSettingValueRecord</code> <p>Description: </p>
/// </summary>
// Name: CustomSettingValueRecord
public partial struct RC_fef56662c61d7afd2d3c90e5f49cfcfa : ITypedRecord<RC_fef56662c61d7afd2d3c90e5f49cfcfa> {
internal static readonly GlobalObjectKey IdCustomSettingValue = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Ymb1_h3G_XotPJDl9Jz8+g");

public EN_ed4c8de87f39a0c4c5e65b9db53df136EntityRecord ssENCustomSettingValue;


public static implicit operator EN_ed4c8de87f39a0c4c5e65b9db53df136EntityRecord( RC_fef56662c61d7afd2d3c90e5f49cfcfa r) {
return r.ssENCustomSettingValue;
}

public static implicit operator RC_fef56662c61d7afd2d3c90e5f49cfcfa (EN_ed4c8de87f39a0c4c5e65b9db53df136EntityRecord r) {
RC_fef56662c61d7afd2d3c90e5f49cfcfa res = new RC_fef56662c61d7afd2d3c90e5f49cfcfa ();
res.ssENCustomSettingValue = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENCustomSettingValue.ChangedAttributes = value;
}
get {
    return ssENCustomSettingValue.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_fef56662c61d7afd2d3c90e5f49cfcfa() {
OptimizedAttributes = null;
ssENCustomSettingValue = new EN_ed4c8de87f39a0c4c5e65b9db53df136EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(5,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENCustomSettingValue.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENCustomSettingValue.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENCustomSettingValue.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
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
public void ReadIM(RC_fef56662c61d7afd2d3c90e5f49cfcfa r) {
this = r;
}


public static bool operator == (RC_fef56662c61d7afd2d3c90e5f49cfcfa a, RC_fef56662c61d7afd2d3c90e5f49cfcfa b) {
if (a.ssENCustomSettingValue != b.ssENCustomSettingValue) return false;
return true;
}

public static bool operator != (RC_fef56662c61d7afd2d3c90e5f49cfcfa a, RC_fef56662c61d7afd2d3c90e5f49cfcfa b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_fef56662c61d7afd2d3c90e5f49cfcfa)) return false;
return (this == (RC_fef56662c61d7afd2d3c90e5f49cfcfa)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENCustomSettingValue.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENCustomSettingValue.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENCustomSettingValue.InternalRecursiveSave();
}


public RC_fef56662c61d7afd2d3c90e5f49cfcfa Duplicate() {
RC_fef56662c61d7afd2d3c90e5f49cfcfa t;
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
if (head == "customsettingvalue") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CustomSettingValue")) variable.Value = ssENCustomSettingValue; else variable.Optimized = true;
variable.SetFieldName("customsettingvalue");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENCustomSettingValue.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENCustomSettingValue.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdCustomSettingValue) {
return ssENCustomSettingValue;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdCustomSettingValue.Key.AsGuid) {
return ssENCustomSettingValue;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENCustomSettingValue.FillFromOther((IRecord) other.AttributeGet(IdCustomSettingValue));
}
} // RC_fef56662c61d7afd2d3c90e5f49cfcfa
/// <summary>
/// RecordList type <code>CustomSettingValueRecordList</code> that represents a record list of
///  <code>CustomSettingValue</code>
/// </summary>
public partial class RL_78f7eb5628c10c7f234959bf22490881 : GenericRecordList<RC_fef56662c61d7afd2d3c90e5f49cfcfa>, IEnumerable, IEnumerator {

protected override RC_fef56662c61d7afd2d3c90e5f49cfcfa GetElementDefaultValue() {
return new RC_fef56662c61d7afd2d3c90e5f49cfcfa();
}

public T[] ToArray<T>(Func<RC_fef56662c61d7afd2d3c90e5f49cfcfa, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_78f7eb5628c10c7f234959bf22490881 recordList, Func<RC_fef56662c61d7afd2d3c90e5f49cfcfa, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_78f7eb5628c10c7f234959bf22490881(RC_fef56662c61d7afd2d3c90e5f49cfcfa[] array) {
  RL_78f7eb5628c10c7f234959bf22490881 result = new RL_78f7eb5628c10c7f234959bf22490881();
result.InnerFromArray(array);
    return result;
}

public static RL_78f7eb5628c10c7f234959bf22490881 ToList<T>(T[] array, Func <T, RC_fef56662c61d7afd2d3c90e5f49cfcfa> converter) {
  RL_78f7eb5628c10c7f234959bf22490881 result = new RL_78f7eb5628c10c7f234959bf22490881();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_78f7eb5628c10c7f234959bf22490881 FromRestList<T>(RestList<T> restList, Func <T, RC_fef56662c61d7afd2d3c90e5f49cfcfa> converter) {
  RL_78f7eb5628c10c7f234959bf22490881 result = new RL_78f7eb5628c10c7f234959bf22490881();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_78f7eb5628c10c7f234959bf22490881() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(5,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_fef56662c61d7afd2d3c90e5f49cfcfa> NewList() {
return new RL_78f7eb5628c10c7f234959bf22490881();
}


} // RL_78f7eb5628c10c7f234959bf22490881
}

