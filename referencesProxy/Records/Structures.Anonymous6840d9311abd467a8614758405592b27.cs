namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (MdlAaL0aekaGFHWEBVkrJw)
///  <code>RC_6d042e8f6faf9c16a51afdc5d65092dd</code> that represents <code>ManualFileRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: ManualFileRecord
public partial struct RC_6d042e8f6faf9c16a51afdc5d65092dd : ITypedRecord<RC_6d042e8f6faf9c16a51afdc5d65092dd> {
internal static readonly GlobalObjectKey IdManualFile = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*jy4Eba9vFpylGv3F1lCS3Q");

public EN_d89d65949fc0664870ebc65ca42d2f63EntityRecord ssENManualFile;


public static implicit operator EN_d89d65949fc0664870ebc65ca42d2f63EntityRecord( RC_6d042e8f6faf9c16a51afdc5d65092dd r) {
return r.ssENManualFile;
}

public static implicit operator RC_6d042e8f6faf9c16a51afdc5d65092dd (EN_d89d65949fc0664870ebc65ca42d2f63EntityRecord r) {
RC_6d042e8f6faf9c16a51afdc5d65092dd res = new RC_6d042e8f6faf9c16a51afdc5d65092dd ();
res.ssENManualFile = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENManualFile.ChangedAttributes = value;
}
get {
    return ssENManualFile.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_6d042e8f6faf9c16a51afdc5d65092dd() {
OptimizedAttributes = null;
ssENManualFile = new EN_d89d65949fc0664870ebc65ca42d2f63EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(4,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENManualFile.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENManualFile.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENManualFile.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENManualFile.Read( r, ref index);
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
public void ReadIM(RC_6d042e8f6faf9c16a51afdc5d65092dd r) {
this = r;
}


public static bool operator == (RC_6d042e8f6faf9c16a51afdc5d65092dd a, RC_6d042e8f6faf9c16a51afdc5d65092dd b) {
if (a.ssENManualFile != b.ssENManualFile) return false;
return true;
}

public static bool operator != (RC_6d042e8f6faf9c16a51afdc5d65092dd a, RC_6d042e8f6faf9c16a51afdc5d65092dd b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_6d042e8f6faf9c16a51afdc5d65092dd)) return false;
return (this == (RC_6d042e8f6faf9c16a51afdc5d65092dd)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENManualFile.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENManualFile.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENManualFile.InternalRecursiveSave();
}


public RC_6d042e8f6faf9c16a51afdc5d65092dd Duplicate() {
RC_6d042e8f6faf9c16a51afdc5d65092dd t;
t.ssENManualFile = (EN_d89d65949fc0664870ebc65ca42d2f63EntityRecord)this.ssENManualFile.Duplicate();
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
if (head == "manualfile") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ManualFile")) variable.Value = ssENManualFile; else variable.Optimized = true;
variable.SetFieldName("manualfile");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENManualFile.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENManualFile.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdManualFile) {
return ssENManualFile;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdManualFile.Key.AsGuid) {
return ssENManualFile;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENManualFile.FillFromOther((IRecord) other.AttributeGet(IdManualFile));
}
} // RC_6d042e8f6faf9c16a51afdc5d65092dd
/// <summary>
/// RecordList type <code>ManualFileRecordList</code> that represents a record list of
///  <code>ManualFile</code>
/// </summary>
public partial class RL_808097b75a7bd51cc15eb7e0762dc255 : GenericRecordList<RC_6d042e8f6faf9c16a51afdc5d65092dd>, IEnumerable, IEnumerator {

protected override RC_6d042e8f6faf9c16a51afdc5d65092dd GetElementDefaultValue() {
return new RC_6d042e8f6faf9c16a51afdc5d65092dd();
}

public T[] ToArray<T>(Func<RC_6d042e8f6faf9c16a51afdc5d65092dd, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_808097b75a7bd51cc15eb7e0762dc255 recordList, Func<RC_6d042e8f6faf9c16a51afdc5d65092dd, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_808097b75a7bd51cc15eb7e0762dc255(RC_6d042e8f6faf9c16a51afdc5d65092dd[] array) {
  RL_808097b75a7bd51cc15eb7e0762dc255 result = new RL_808097b75a7bd51cc15eb7e0762dc255();
result.InnerFromArray(array);
    return result;
}

public static RL_808097b75a7bd51cc15eb7e0762dc255 ToList<T>(T[] array, Func <T, RC_6d042e8f6faf9c16a51afdc5d65092dd> converter) {
  RL_808097b75a7bd51cc15eb7e0762dc255 result = new RL_808097b75a7bd51cc15eb7e0762dc255();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_808097b75a7bd51cc15eb7e0762dc255 FromRestList<T>(RestList<T> restList, Func <T, RC_6d042e8f6faf9c16a51afdc5d65092dd> converter) {
  RL_808097b75a7bd51cc15eb7e0762dc255 result = new RL_808097b75a7bd51cc15eb7e0762dc255();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_808097b75a7bd51cc15eb7e0762dc255() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(4,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_6d042e8f6faf9c16a51afdc5d65092dd> NewList() {
return new RL_808097b75a7bd51cc15eb7e0762dc255();
}


} // RL_808097b75a7bd51cc15eb7e0762dc255
}

