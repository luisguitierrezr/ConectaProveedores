namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (CRuFJFDdyUObq0+Z6EDdhA)
///  <code>RC_cfeb2cf80ab683e7d9a9b5d02d9c9526</code> that represents <code>FolioRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: FolioRecord
public partial struct RC_cfeb2cf80ab683e7d9a9b5d02d9c9526 : ITypedRecord<RC_cfeb2cf80ab683e7d9a9b5d02d9c9526> {
internal static readonly GlobalObjectKey IdFolio = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*+Czrz7YK54PZqbXQLZyVJg");

public EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord ssENFolio;


public static implicit operator EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord( RC_cfeb2cf80ab683e7d9a9b5d02d9c9526 r) {
return r.ssENFolio;
}

public static implicit operator RC_cfeb2cf80ab683e7d9a9b5d02d9c9526 (EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord r) {
RC_cfeb2cf80ab683e7d9a9b5d02d9c9526 res = new RC_cfeb2cf80ab683e7d9a9b5d02d9c9526 ();
res.ssENFolio = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENFolio.ChangedAttributes = value;
}
get {
    return ssENFolio.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_cfeb2cf80ab683e7d9a9b5d02d9c9526() {
OptimizedAttributes = null;
ssENFolio = new EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(20,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENFolio.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENFolio.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENFolio.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENFolio.Read( r, ref index);
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
public void ReadIM(RC_cfeb2cf80ab683e7d9a9b5d02d9c9526 r) {
this = r;
}


public static bool operator == (RC_cfeb2cf80ab683e7d9a9b5d02d9c9526 a, RC_cfeb2cf80ab683e7d9a9b5d02d9c9526 b) {
if (a.ssENFolio != b.ssENFolio) return false;
return true;
}

public static bool operator != (RC_cfeb2cf80ab683e7d9a9b5d02d9c9526 a, RC_cfeb2cf80ab683e7d9a9b5d02d9c9526 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_cfeb2cf80ab683e7d9a9b5d02d9c9526)) return false;
return (this == (RC_cfeb2cf80ab683e7d9a9b5d02d9c9526)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENFolio.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENFolio.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENFolio.InternalRecursiveSave();
}


public RC_cfeb2cf80ab683e7d9a9b5d02d9c9526 Duplicate() {
RC_cfeb2cf80ab683e7d9a9b5d02d9c9526 t;
t.ssENFolio = (EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord)this.ssENFolio.Duplicate();
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
if (head == "folio") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Folio")) variable.Value = ssENFolio; else variable.Optimized = true;
variable.SetFieldName("folio");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENFolio.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENFolio.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdFolio) {
return ssENFolio;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdFolio.Key.AsGuid) {
return ssENFolio;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENFolio.FillFromOther((IRecord) other.AttributeGet(IdFolio));
}
} // RC_cfeb2cf80ab683e7d9a9b5d02d9c9526
/// <summary>
/// RecordList type <code>FolioRecordList</code> that represents a record list of <code>Folio</code>
/// </summary>
public partial class RL_4f8b259bdd04db22be8fb771f1ad1d4f : GenericRecordList<RC_cfeb2cf80ab683e7d9a9b5d02d9c9526>, IEnumerable, IEnumerator {

protected override RC_cfeb2cf80ab683e7d9a9b5d02d9c9526 GetElementDefaultValue() {
return new RC_cfeb2cf80ab683e7d9a9b5d02d9c9526();
}

public T[] ToArray<T>(Func<RC_cfeb2cf80ab683e7d9a9b5d02d9c9526, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_4f8b259bdd04db22be8fb771f1ad1d4f recordList, Func<RC_cfeb2cf80ab683e7d9a9b5d02d9c9526, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_4f8b259bdd04db22be8fb771f1ad1d4f(RC_cfeb2cf80ab683e7d9a9b5d02d9c9526[] array) {
  RL_4f8b259bdd04db22be8fb771f1ad1d4f result = new RL_4f8b259bdd04db22be8fb771f1ad1d4f();
result.InnerFromArray(array);
    return result;
}

public static RL_4f8b259bdd04db22be8fb771f1ad1d4f ToList<T>(T[] array, Func <T, RC_cfeb2cf80ab683e7d9a9b5d02d9c9526> converter) {
  RL_4f8b259bdd04db22be8fb771f1ad1d4f result = new RL_4f8b259bdd04db22be8fb771f1ad1d4f();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_4f8b259bdd04db22be8fb771f1ad1d4f FromRestList<T>(RestList<T> restList, Func <T, RC_cfeb2cf80ab683e7d9a9b5d02d9c9526> converter) {
  RL_4f8b259bdd04db22be8fb771f1ad1d4f result = new RL_4f8b259bdd04db22be8fb771f1ad1d4f();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_4f8b259bdd04db22be8fb771f1ad1d4f() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(20,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_cfeb2cf80ab683e7d9a9b5d02d9c9526> NewList() {
return new RL_4f8b259bdd04db22be8fb771f1ad1d4f();
}


} // RL_4f8b259bdd04db22be8fb771f1ad1d4f
}

