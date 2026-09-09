namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (iUg2stZviUezRa5kHzaTKA)
///  <code>RC_51b1c15949308af5f9b2dba7043d5ae6</code> that represent
/// s <code>DatePickerTimeFormatRecord</code> <p>Description: </p>
/// </summary>
// Name: DatePickerTimeFormatRecord
public partial struct RC_51b1c15949308af5f9b2dba7043d5ae6 : ITypedRecord<RC_51b1c15949308af5f9b2dba7043d5ae6> {
internal static readonly GlobalObjectKey IdDatePickerTimeFormat = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*WcGxUTBJ9Yr5stunBD1a5g");

public EN_b4e36c9529d7446e086560192df48d7cEntityRecord ssENDatePickerTimeFormat;


public static implicit operator EN_b4e36c9529d7446e086560192df48d7cEntityRecord( RC_51b1c15949308af5f9b2dba7043d5ae6 r) {
return r.ssENDatePickerTimeFormat;
}

public static implicit operator RC_51b1c15949308af5f9b2dba7043d5ae6 (EN_b4e36c9529d7446e086560192df48d7cEntityRecord r) {
RC_51b1c15949308af5f9b2dba7043d5ae6 res = new RC_51b1c15949308af5f9b2dba7043d5ae6 ();
res.ssENDatePickerTimeFormat = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENDatePickerTimeFormat.ChangedAttributes = value;
}
get {
    return ssENDatePickerTimeFormat.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_51b1c15949308af5f9b2dba7043d5ae6() {
OptimizedAttributes = null;
ssENDatePickerTimeFormat = new EN_b4e36c9529d7446e086560192df48d7cEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(1,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENDatePickerTimeFormat.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENDatePickerTimeFormat.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENDatePickerTimeFormat.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENDatePickerTimeFormat.Read( r, ref index);
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
public void ReadIM(RC_51b1c15949308af5f9b2dba7043d5ae6 r) {
this = r;
}


public static bool operator == (RC_51b1c15949308af5f9b2dba7043d5ae6 a, RC_51b1c15949308af5f9b2dba7043d5ae6 b) {
if (a.ssENDatePickerTimeFormat != b.ssENDatePickerTimeFormat) return false;
return true;
}

public static bool operator != (RC_51b1c15949308af5f9b2dba7043d5ae6 a, RC_51b1c15949308af5f9b2dba7043d5ae6 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_51b1c15949308af5f9b2dba7043d5ae6)) return false;
return (this == (RC_51b1c15949308af5f9b2dba7043d5ae6)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENDatePickerTimeFormat.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENDatePickerTimeFormat.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENDatePickerTimeFormat.InternalRecursiveSave();
}


public RC_51b1c15949308af5f9b2dba7043d5ae6 Duplicate() {
RC_51b1c15949308af5f9b2dba7043d5ae6 t;
t.ssENDatePickerTimeFormat = (EN_b4e36c9529d7446e086560192df48d7cEntityRecord)this.ssENDatePickerTimeFormat.Duplicate();
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
if (head == "datepickertimeformat") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DatePickerTimeFormat")) variable.Value = ssENDatePickerTimeFormat; else variable.Optimized = true;
variable.SetFieldName("datepickertimeformat");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENDatePickerTimeFormat.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENDatePickerTimeFormat.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdDatePickerTimeFormat) {
return ssENDatePickerTimeFormat;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdDatePickerTimeFormat.Key.AsGuid) {
return ssENDatePickerTimeFormat;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENDatePickerTimeFormat.FillFromOther((IRecord) other.AttributeGet(IdDatePickerTimeFormat));
}
} // RC_51b1c15949308af5f9b2dba7043d5ae6
/// <summary>
/// RecordList type <code>DatePickerTimeFormatRecordList</code> that represents a record list of
///  <code>DatePickerTimeFormat</code>
/// </summary>
public partial class RL_c564b1e63d41953ea9734fb248f40109 : GenericRecordList<RC_51b1c15949308af5f9b2dba7043d5ae6>, IEnumerable, IEnumerator {

protected override RC_51b1c15949308af5f9b2dba7043d5ae6 GetElementDefaultValue() {
return new RC_51b1c15949308af5f9b2dba7043d5ae6();
}

public T[] ToArray<T>(Func<RC_51b1c15949308af5f9b2dba7043d5ae6, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_c564b1e63d41953ea9734fb248f40109 recordList, Func<RC_51b1c15949308af5f9b2dba7043d5ae6, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_c564b1e63d41953ea9734fb248f40109(RC_51b1c15949308af5f9b2dba7043d5ae6[] array) {
  RL_c564b1e63d41953ea9734fb248f40109 result = new RL_c564b1e63d41953ea9734fb248f40109();
result.InnerFromArray(array);
    return result;
}

public static RL_c564b1e63d41953ea9734fb248f40109 ToList<T>(T[] array, Func <T, RC_51b1c15949308af5f9b2dba7043d5ae6> converter) {
  RL_c564b1e63d41953ea9734fb248f40109 result = new RL_c564b1e63d41953ea9734fb248f40109();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_c564b1e63d41953ea9734fb248f40109 FromRestList<T>(RestList<T> restList, Func <T, RC_51b1c15949308af5f9b2dba7043d5ae6> converter) {
  RL_c564b1e63d41953ea9734fb248f40109 result = new RL_c564b1e63d41953ea9734fb248f40109();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_c564b1e63d41953ea9734fb248f40109() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(1,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_51b1c15949308af5f9b2dba7043d5ae6> NewList() {
return new RL_c564b1e63d41953ea9734fb248f40109();
}


} // RL_c564b1e63d41953ea9734fb248f40109
}

