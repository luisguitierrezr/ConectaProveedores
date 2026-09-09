namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (LYfVMJyTfE+nM_8EBYHNIA)
///  <code>RC_bdb8cd2e0da3eae2f170942895f2a3ac</code> that represent
/// s <code>OrderContractFileRecord</code> <p>Description: </p>
/// </summary>
// Name: OrderContractFileRecord
public partial struct RC_bdb8cd2e0da3eae2f170942895f2a3ac : ITypedRecord<RC_bdb8cd2e0da3eae2f170942895f2a3ac> {
internal static readonly GlobalObjectKey IdOrderContractFile = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Ls24vaMN4urxcJQolfKjrA");

public EN_17538b35348920159ed0ee43b3fb2b50EntityRecord ssENOrderContractFile;


public static implicit operator EN_17538b35348920159ed0ee43b3fb2b50EntityRecord( RC_bdb8cd2e0da3eae2f170942895f2a3ac r) {
return r.ssENOrderContractFile;
}

public static implicit operator RC_bdb8cd2e0da3eae2f170942895f2a3ac (EN_17538b35348920159ed0ee43b3fb2b50EntityRecord r) {
RC_bdb8cd2e0da3eae2f170942895f2a3ac res = new RC_bdb8cd2e0da3eae2f170942895f2a3ac ();
res.ssENOrderContractFile = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENOrderContractFile.ChangedAttributes = value;
}
get {
    return ssENOrderContractFile.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_bdb8cd2e0da3eae2f170942895f2a3ac() {
OptimizedAttributes = null;
ssENOrderContractFile = new EN_17538b35348920159ed0ee43b3fb2b50EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(14,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENOrderContractFile.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENOrderContractFile.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENOrderContractFile.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENOrderContractFile.Read( r, ref index);
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
public void ReadIM(RC_bdb8cd2e0da3eae2f170942895f2a3ac r) {
this = r;
}


public static bool operator == (RC_bdb8cd2e0da3eae2f170942895f2a3ac a, RC_bdb8cd2e0da3eae2f170942895f2a3ac b) {
if (a.ssENOrderContractFile != b.ssENOrderContractFile) return false;
return true;
}

public static bool operator != (RC_bdb8cd2e0da3eae2f170942895f2a3ac a, RC_bdb8cd2e0da3eae2f170942895f2a3ac b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_bdb8cd2e0da3eae2f170942895f2a3ac)) return false;
return (this == (RC_bdb8cd2e0da3eae2f170942895f2a3ac)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENOrderContractFile.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENOrderContractFile.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENOrderContractFile.InternalRecursiveSave();
}


public RC_bdb8cd2e0da3eae2f170942895f2a3ac Duplicate() {
RC_bdb8cd2e0da3eae2f170942895f2a3ac t;
t.ssENOrderContractFile = (EN_17538b35348920159ed0ee43b3fb2b50EntityRecord)this.ssENOrderContractFile.Duplicate();
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
if (head == "ordercontractfile") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderContractFile")) variable.Value = ssENOrderContractFile; else variable.Optimized = true;
variable.SetFieldName("ordercontractfile");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENOrderContractFile.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENOrderContractFile.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdOrderContractFile) {
return ssENOrderContractFile;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOrderContractFile.Key.AsGuid) {
return ssENOrderContractFile;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENOrderContractFile.FillFromOther((IRecord) other.AttributeGet(IdOrderContractFile));
}
} // RC_bdb8cd2e0da3eae2f170942895f2a3ac
/// <summary>
/// RecordList type <code>OrderContractFileRecordList</code> that represents a record list of
///  <code>OrderContractFile</code>
/// </summary>
public partial class RL_0c8daebacea14512c4f2bc71294af3cc : GenericRecordList<RC_bdb8cd2e0da3eae2f170942895f2a3ac>, IEnumerable, IEnumerator {

protected override RC_bdb8cd2e0da3eae2f170942895f2a3ac GetElementDefaultValue() {
return new RC_bdb8cd2e0da3eae2f170942895f2a3ac();
}

public T[] ToArray<T>(Func<RC_bdb8cd2e0da3eae2f170942895f2a3ac, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_0c8daebacea14512c4f2bc71294af3cc recordList, Func<RC_bdb8cd2e0da3eae2f170942895f2a3ac, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_0c8daebacea14512c4f2bc71294af3cc(RC_bdb8cd2e0da3eae2f170942895f2a3ac[] array) {
  RL_0c8daebacea14512c4f2bc71294af3cc result = new RL_0c8daebacea14512c4f2bc71294af3cc();
result.InnerFromArray(array);
    return result;
}

public static RL_0c8daebacea14512c4f2bc71294af3cc ToList<T>(T[] array, Func <T, RC_bdb8cd2e0da3eae2f170942895f2a3ac> converter) {
  RL_0c8daebacea14512c4f2bc71294af3cc result = new RL_0c8daebacea14512c4f2bc71294af3cc();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_0c8daebacea14512c4f2bc71294af3cc FromRestList<T>(RestList<T> restList, Func <T, RC_bdb8cd2e0da3eae2f170942895f2a3ac> converter) {
  RL_0c8daebacea14512c4f2bc71294af3cc result = new RL_0c8daebacea14512c4f2bc71294af3cc();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_0c8daebacea14512c4f2bc71294af3cc() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(14,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_bdb8cd2e0da3eae2f170942895f2a3ac> NewList() {
return new RL_0c8daebacea14512c4f2bc71294af3cc();
}


} // RL_0c8daebacea14512c4f2bc71294af3cc
}

