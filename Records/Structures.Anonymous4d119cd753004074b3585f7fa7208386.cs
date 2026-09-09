namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (15wRTQBTdECzWF9_pyCDhg)
///  <code>RC_28fdb7a8aef891dc921c5fe34393a569</code> that represents <code>FolioFilesRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: FolioFilesRecord
public partial struct RC_28fdb7a8aef891dc921c5fe34393a569 : ITypedRecord<RC_28fdb7a8aef891dc921c5fe34393a569> {
internal static readonly GlobalObjectKey IdFolioFiles = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*qLf9KPiu3JGSHF_jQ5OlaQ");

public EN_b64035ee1e9a04282d937f5f4e7a7952EntityRecord ssENFolioFiles;


public static implicit operator EN_b64035ee1e9a04282d937f5f4e7a7952EntityRecord( RC_28fdb7a8aef891dc921c5fe34393a569 r) {
return r.ssENFolioFiles;
}

public static implicit operator RC_28fdb7a8aef891dc921c5fe34393a569 (EN_b64035ee1e9a04282d937f5f4e7a7952EntityRecord r) {
RC_28fdb7a8aef891dc921c5fe34393a569 res = new RC_28fdb7a8aef891dc921c5fe34393a569 ();
res.ssENFolioFiles = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENFolioFiles.ChangedAttributes = value;
}
get {
    return ssENFolioFiles.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_28fdb7a8aef891dc921c5fe34393a569() {
OptimizedAttributes = null;
ssENFolioFiles = new EN_b64035ee1e9a04282d937f5f4e7a7952EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(8,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENFolioFiles.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENFolioFiles.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENFolioFiles.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENFolioFiles.Read( r, ref index);
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
public void ReadIM(RC_28fdb7a8aef891dc921c5fe34393a569 r) {
this = r;
}


public static bool operator == (RC_28fdb7a8aef891dc921c5fe34393a569 a, RC_28fdb7a8aef891dc921c5fe34393a569 b) {
if (a.ssENFolioFiles != b.ssENFolioFiles) return false;
return true;
}

public static bool operator != (RC_28fdb7a8aef891dc921c5fe34393a569 a, RC_28fdb7a8aef891dc921c5fe34393a569 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_28fdb7a8aef891dc921c5fe34393a569)) return false;
return (this == (RC_28fdb7a8aef891dc921c5fe34393a569)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENFolioFiles.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENFolioFiles.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENFolioFiles.InternalRecursiveSave();
}


public RC_28fdb7a8aef891dc921c5fe34393a569 Duplicate() {
RC_28fdb7a8aef891dc921c5fe34393a569 t;
t.ssENFolioFiles = (EN_b64035ee1e9a04282d937f5f4e7a7952EntityRecord)this.ssENFolioFiles.Duplicate();
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
if (head == "foliofiles") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FolioFiles")) variable.Value = ssENFolioFiles; else variable.Optimized = true;
variable.SetFieldName("foliofiles");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENFolioFiles.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENFolioFiles.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdFolioFiles) {
return ssENFolioFiles;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdFolioFiles.Key.AsGuid) {
return ssENFolioFiles;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENFolioFiles.FillFromOther((IRecord) other.AttributeGet(IdFolioFiles));
}
} // RC_28fdb7a8aef891dc921c5fe34393a569
/// <summary>
/// RecordList type <code>FolioFilesRecordList</code> that represents a record list of
///  <code>FolioFiles</code>
/// </summary>
public partial class RL_897c95bca5499c293930e47bf793d0d9 : GenericRecordList<RC_28fdb7a8aef891dc921c5fe34393a569>, IEnumerable, IEnumerator {

protected override RC_28fdb7a8aef891dc921c5fe34393a569 GetElementDefaultValue() {
return new RC_28fdb7a8aef891dc921c5fe34393a569();
}

public T[] ToArray<T>(Func<RC_28fdb7a8aef891dc921c5fe34393a569, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_897c95bca5499c293930e47bf793d0d9 recordList, Func<RC_28fdb7a8aef891dc921c5fe34393a569, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_897c95bca5499c293930e47bf793d0d9(RC_28fdb7a8aef891dc921c5fe34393a569[] array) {
  RL_897c95bca5499c293930e47bf793d0d9 result = new RL_897c95bca5499c293930e47bf793d0d9();
result.InnerFromArray(array);
    return result;
}

public static RL_897c95bca5499c293930e47bf793d0d9 ToList<T>(T[] array, Func <T, RC_28fdb7a8aef891dc921c5fe34393a569> converter) {
  RL_897c95bca5499c293930e47bf793d0d9 result = new RL_897c95bca5499c293930e47bf793d0d9();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_897c95bca5499c293930e47bf793d0d9 FromRestList<T>(RestList<T> restList, Func <T, RC_28fdb7a8aef891dc921c5fe34393a569> converter) {
  RL_897c95bca5499c293930e47bf793d0d9 result = new RL_897c95bca5499c293930e47bf793d0d9();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_897c95bca5499c293930e47bf793d0d9() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(8,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_28fdb7a8aef891dc921c5fe34393a569> NewList() {
return new RL_897c95bca5499c293930e47bf793d0d9();
}


} // RL_897c95bca5499c293930e47bf793d0d9
}

