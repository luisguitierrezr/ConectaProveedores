namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (j3zJruvs_kmL0VjACKGF9g)
///  <code>RC_97877e692c313605c09a0be8396b97b4</code> that represents <code>ManagementRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: ManagementRecord
public partial struct RC_97877e692c313605c09a0be8396b97b4 : ITypedRecord<RC_97877e692c313605c09a0be8396b97b4> {
internal static readonly GlobalObjectKey IdManagement = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*aX6HlzEsBTbAmgvoOWuXtA");

public EN_57ed198e55e574aae8caa812c90093e4EntityRecord ssENManagement;


public static implicit operator EN_57ed198e55e574aae8caa812c90093e4EntityRecord( RC_97877e692c313605c09a0be8396b97b4 r) {
return r.ssENManagement;
}

public static implicit operator RC_97877e692c313605c09a0be8396b97b4 (EN_57ed198e55e574aae8caa812c90093e4EntityRecord r) {
RC_97877e692c313605c09a0be8396b97b4 res = new RC_97877e692c313605c09a0be8396b97b4 ();
res.ssENManagement = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENManagement.ChangedAttributes = value;
}
get {
    return ssENManagement.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_97877e692c313605c09a0be8396b97b4() {
OptimizedAttributes = null;
ssENManagement = new EN_57ed198e55e574aae8caa812c90093e4EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(7,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENManagement.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENManagement.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENManagement.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENManagement.Read( r, ref index);
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
public void ReadIM(RC_97877e692c313605c09a0be8396b97b4 r) {
this = r;
}


public static bool operator == (RC_97877e692c313605c09a0be8396b97b4 a, RC_97877e692c313605c09a0be8396b97b4 b) {
if (a.ssENManagement != b.ssENManagement) return false;
return true;
}

public static bool operator != (RC_97877e692c313605c09a0be8396b97b4 a, RC_97877e692c313605c09a0be8396b97b4 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_97877e692c313605c09a0be8396b97b4)) return false;
return (this == (RC_97877e692c313605c09a0be8396b97b4)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENManagement.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENManagement.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENManagement.InternalRecursiveSave();
}


public RC_97877e692c313605c09a0be8396b97b4 Duplicate() {
RC_97877e692c313605c09a0be8396b97b4 t;
t.ssENManagement = (EN_57ed198e55e574aae8caa812c90093e4EntityRecord)this.ssENManagement.Duplicate();
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
if (head == "management") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Management")) variable.Value = ssENManagement; else variable.Optimized = true;
variable.SetFieldName("management");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENManagement.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENManagement.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdManagement) {
return ssENManagement;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdManagement.Key.AsGuid) {
return ssENManagement;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENManagement.FillFromOther((IRecord) other.AttributeGet(IdManagement));
}
} // RC_97877e692c313605c09a0be8396b97b4
/// <summary>
/// RecordList type <code>ManagementRecordList</code> that represents a record list of
///  <code>Management</code>
/// </summary>
public partial class RL_a4f8c145eaf0f39920aa03a60102b080 : GenericRecordList<RC_97877e692c313605c09a0be8396b97b4>, IEnumerable, IEnumerator {

protected override RC_97877e692c313605c09a0be8396b97b4 GetElementDefaultValue() {
return new RC_97877e692c313605c09a0be8396b97b4();
}

public T[] ToArray<T>(Func<RC_97877e692c313605c09a0be8396b97b4, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_a4f8c145eaf0f39920aa03a60102b080 recordList, Func<RC_97877e692c313605c09a0be8396b97b4, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_a4f8c145eaf0f39920aa03a60102b080(RC_97877e692c313605c09a0be8396b97b4[] array) {
  RL_a4f8c145eaf0f39920aa03a60102b080 result = new RL_a4f8c145eaf0f39920aa03a60102b080();
result.InnerFromArray(array);
    return result;
}

public static RL_a4f8c145eaf0f39920aa03a60102b080 ToList<T>(T[] array, Func <T, RC_97877e692c313605c09a0be8396b97b4> converter) {
  RL_a4f8c145eaf0f39920aa03a60102b080 result = new RL_a4f8c145eaf0f39920aa03a60102b080();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_a4f8c145eaf0f39920aa03a60102b080 FromRestList<T>(RestList<T> restList, Func <T, RC_97877e692c313605c09a0be8396b97b4> converter) {
  RL_a4f8c145eaf0f39920aa03a60102b080 result = new RL_a4f8c145eaf0f39920aa03a60102b080();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_a4f8c145eaf0f39920aa03a60102b080() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(7,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_97877e692c313605c09a0be8396b97b4> NewList() {
return new RL_a4f8c145eaf0f39920aa03a60102b080();
}


} // RL_a4f8c145eaf0f39920aa03a60102b080
}

