namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (hcsfCoSgz0q3T8zRAb83AQ)
///  <code>RC_a091342374a4b333cc44c9d3c7cd8caa</code> that represents <code>DepartmentRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: DepartmentRecord
public partial struct RC_a091342374a4b333cc44c9d3c7cd8caa : ITypedRecord<RC_a091342374a4b333cc44c9d3c7cd8caa> {
internal static readonly GlobalObjectKey IdDepartment = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*IzSRoKR0M7PMRMnTx82Mqg");

public EN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord ssENDepartment;


public static implicit operator EN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord( RC_a091342374a4b333cc44c9d3c7cd8caa r) {
return r.ssENDepartment;
}

public static implicit operator RC_a091342374a4b333cc44c9d3c7cd8caa (EN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord r) {
RC_a091342374a4b333cc44c9d3c7cd8caa res = new RC_a091342374a4b333cc44c9d3c7cd8caa ();
res.ssENDepartment = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENDepartment.ChangedAttributes = value;
}
get {
    return ssENDepartment.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_a091342374a4b333cc44c9d3c7cd8caa() {
OptimizedAttributes = null;
ssENDepartment = new EN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(7,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENDepartment.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENDepartment.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENDepartment.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENDepartment.Read( r, ref index);
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
public void ReadIM(RC_a091342374a4b333cc44c9d3c7cd8caa r) {
this = r;
}


public static bool operator == (RC_a091342374a4b333cc44c9d3c7cd8caa a, RC_a091342374a4b333cc44c9d3c7cd8caa b) {
if (a.ssENDepartment != b.ssENDepartment) return false;
return true;
}

public static bool operator != (RC_a091342374a4b333cc44c9d3c7cd8caa a, RC_a091342374a4b333cc44c9d3c7cd8caa b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_a091342374a4b333cc44c9d3c7cd8caa)) return false;
return (this == (RC_a091342374a4b333cc44c9d3c7cd8caa)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENDepartment.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENDepartment.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENDepartment.InternalRecursiveSave();
}


public RC_a091342374a4b333cc44c9d3c7cd8caa Duplicate() {
RC_a091342374a4b333cc44c9d3c7cd8caa t;
t.ssENDepartment = (EN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord)this.ssENDepartment.Duplicate();
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
if (head == "department") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Department")) variable.Value = ssENDepartment; else variable.Optimized = true;
variable.SetFieldName("department");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENDepartment.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENDepartment.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdDepartment) {
return ssENDepartment;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdDepartment.Key.AsGuid) {
return ssENDepartment;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENDepartment.FillFromOther((IRecord) other.AttributeGet(IdDepartment));
}
} // RC_a091342374a4b333cc44c9d3c7cd8caa
/// <summary>
/// RecordList type <code>DepartmentRecordList</code> that represents a record list of
///  <code>Department</code>
/// </summary>
public partial class RL_e8b38f19d5408ab9575d33bcd7baacd9 : GenericRecordList<RC_a091342374a4b333cc44c9d3c7cd8caa>, IEnumerable, IEnumerator {

protected override RC_a091342374a4b333cc44c9d3c7cd8caa GetElementDefaultValue() {
return new RC_a091342374a4b333cc44c9d3c7cd8caa();
}

public T[] ToArray<T>(Func<RC_a091342374a4b333cc44c9d3c7cd8caa, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_e8b38f19d5408ab9575d33bcd7baacd9 recordList, Func<RC_a091342374a4b333cc44c9d3c7cd8caa, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_e8b38f19d5408ab9575d33bcd7baacd9(RC_a091342374a4b333cc44c9d3c7cd8caa[] array) {
  RL_e8b38f19d5408ab9575d33bcd7baacd9 result = new RL_e8b38f19d5408ab9575d33bcd7baacd9();
result.InnerFromArray(array);
    return result;
}

public static RL_e8b38f19d5408ab9575d33bcd7baacd9 ToList<T>(T[] array, Func <T, RC_a091342374a4b333cc44c9d3c7cd8caa> converter) {
  RL_e8b38f19d5408ab9575d33bcd7baacd9 result = new RL_e8b38f19d5408ab9575d33bcd7baacd9();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_e8b38f19d5408ab9575d33bcd7baacd9 FromRestList<T>(RestList<T> restList, Func <T, RC_a091342374a4b333cc44c9d3c7cd8caa> converter) {
  RL_e8b38f19d5408ab9575d33bcd7baacd9 result = new RL_e8b38f19d5408ab9575d33bcd7baacd9();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_e8b38f19d5408ab9575d33bcd7baacd9() : base() {
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
protected override OSList<RC_a091342374a4b333cc44c9d3c7cd8caa> NewList() {
return new RL_e8b38f19d5408ab9575d33bcd7baacd9();
}


} // RL_e8b38f19d5408ab9575d33bcd7baacd9
}

