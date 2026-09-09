namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (ao7xB2C030+4Kkeyy1PQFg)
///  <code>RC_99a1fa6df481ec5b1908e770c81b73b1</code> that represents <code>CompanyRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: CompanyRecord
public partial struct RC_99a1fa6df481ec5b1908e770c81b73b1 : ITypedRecord<RC_99a1fa6df481ec5b1908e770c81b73b1> {
internal static readonly GlobalObjectKey IdCompany = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*bfqhmYH0W+wZCOdwyBtzsQ");

public EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord ssENCompany;


public static implicit operator EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord( RC_99a1fa6df481ec5b1908e770c81b73b1 r) {
return r.ssENCompany;
}

public static implicit operator RC_99a1fa6df481ec5b1908e770c81b73b1 (EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord r) {
RC_99a1fa6df481ec5b1908e770c81b73b1 res = new RC_99a1fa6df481ec5b1908e770c81b73b1 ();
res.ssENCompany = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENCompany.ChangedAttributes = value;
}
get {
    return ssENCompany.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_99a1fa6df481ec5b1908e770c81b73b1() {
OptimizedAttributes = null;
ssENCompany = new EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(11,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENCompany.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENCompany.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENCompany.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENCompany.Read( r, ref index);
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
public void ReadIM(RC_99a1fa6df481ec5b1908e770c81b73b1 r) {
this = r;
}


public static bool operator == (RC_99a1fa6df481ec5b1908e770c81b73b1 a, RC_99a1fa6df481ec5b1908e770c81b73b1 b) {
if (a.ssENCompany != b.ssENCompany) return false;
return true;
}

public static bool operator != (RC_99a1fa6df481ec5b1908e770c81b73b1 a, RC_99a1fa6df481ec5b1908e770c81b73b1 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_99a1fa6df481ec5b1908e770c81b73b1)) return false;
return (this == (RC_99a1fa6df481ec5b1908e770c81b73b1)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENCompany.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENCompany.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENCompany.InternalRecursiveSave();
}


public RC_99a1fa6df481ec5b1908e770c81b73b1 Duplicate() {
RC_99a1fa6df481ec5b1908e770c81b73b1 t;
t.ssENCompany = (EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord)this.ssENCompany.Duplicate();
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
if (head == "company") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Company")) variable.Value = ssENCompany; else variable.Optimized = true;
variable.SetFieldName("company");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENCompany.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENCompany.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdCompany) {
return ssENCompany;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdCompany.Key.AsGuid) {
return ssENCompany;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENCompany.FillFromOther((IRecord) other.AttributeGet(IdCompany));
}
} // RC_99a1fa6df481ec5b1908e770c81b73b1
/// <summary>
/// RecordList type <code>CompanyRecordList</code> that represents a record list of
///  <code>Company</code>
/// </summary>
public partial class RL_060f887b4f32b5cdb78b49175875565c : GenericRecordList<RC_99a1fa6df481ec5b1908e770c81b73b1>, IEnumerable, IEnumerator {

protected override RC_99a1fa6df481ec5b1908e770c81b73b1 GetElementDefaultValue() {
return new RC_99a1fa6df481ec5b1908e770c81b73b1();
}

public T[] ToArray<T>(Func<RC_99a1fa6df481ec5b1908e770c81b73b1, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_060f887b4f32b5cdb78b49175875565c recordList, Func<RC_99a1fa6df481ec5b1908e770c81b73b1, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_060f887b4f32b5cdb78b49175875565c(RC_99a1fa6df481ec5b1908e770c81b73b1[] array) {
  RL_060f887b4f32b5cdb78b49175875565c result = new RL_060f887b4f32b5cdb78b49175875565c();
result.InnerFromArray(array);
    return result;
}

public static RL_060f887b4f32b5cdb78b49175875565c ToList<T>(T[] array, Func <T, RC_99a1fa6df481ec5b1908e770c81b73b1> converter) {
  RL_060f887b4f32b5cdb78b49175875565c result = new RL_060f887b4f32b5cdb78b49175875565c();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_060f887b4f32b5cdb78b49175875565c FromRestList<T>(RestList<T> restList, Func <T, RC_99a1fa6df481ec5b1908e770c81b73b1> converter) {
  RL_060f887b4f32b5cdb78b49175875565c result = new RL_060f887b4f32b5cdb78b49175875565c();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_060f887b4f32b5cdb78b49175875565c() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(11,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_99a1fa6df481ec5b1908e770c81b73b1> NewList() {
return new RL_060f887b4f32b5cdb78b49175875565c();
}


} // RL_060f887b4f32b5cdb78b49175875565c
}

