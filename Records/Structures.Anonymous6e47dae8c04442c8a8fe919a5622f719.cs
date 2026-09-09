namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (6NpHbkTAyEKo_pGaViL3GQ)
///  <code>RC_46822aff680dcd6a1139ef31b620e73d</code> that represents <code>EntraDomainRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: EntraDomainRecord
public partial struct RC_46822aff680dcd6a1139ef31b620e73d : ITypedRecord<RC_46822aff680dcd6a1139ef31b620e73d> {
internal static readonly GlobalObjectKey IdEntraDomain = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*_yqCRg1oas0ROe8xtiDnPQ");

public EN_635849dd879ffe94511aeebfcff26dbcEntityRecord ssENEntraDomain;


public static implicit operator EN_635849dd879ffe94511aeebfcff26dbcEntityRecord( RC_46822aff680dcd6a1139ef31b620e73d r) {
return r.ssENEntraDomain;
}

public static implicit operator RC_46822aff680dcd6a1139ef31b620e73d (EN_635849dd879ffe94511aeebfcff26dbcEntityRecord r) {
RC_46822aff680dcd6a1139ef31b620e73d res = new RC_46822aff680dcd6a1139ef31b620e73d ();
res.ssENEntraDomain = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENEntraDomain.ChangedAttributes = value;
}
get {
    return ssENEntraDomain.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_46822aff680dcd6a1139ef31b620e73d() {
OptimizedAttributes = null;
ssENEntraDomain = new EN_635849dd879ffe94511aeebfcff26dbcEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(5,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENEntraDomain.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENEntraDomain.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENEntraDomain.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENEntraDomain.Read( r, ref index);
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
public void ReadIM(RC_46822aff680dcd6a1139ef31b620e73d r) {
this = r;
}


public static bool operator == (RC_46822aff680dcd6a1139ef31b620e73d a, RC_46822aff680dcd6a1139ef31b620e73d b) {
if (a.ssENEntraDomain != b.ssENEntraDomain) return false;
return true;
}

public static bool operator != (RC_46822aff680dcd6a1139ef31b620e73d a, RC_46822aff680dcd6a1139ef31b620e73d b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_46822aff680dcd6a1139ef31b620e73d)) return false;
return (this == (RC_46822aff680dcd6a1139ef31b620e73d)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENEntraDomain.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENEntraDomain.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENEntraDomain.InternalRecursiveSave();
}


public RC_46822aff680dcd6a1139ef31b620e73d Duplicate() {
RC_46822aff680dcd6a1139ef31b620e73d t;
t.ssENEntraDomain = (EN_635849dd879ffe94511aeebfcff26dbcEntityRecord)this.ssENEntraDomain.Duplicate();
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
if (head == "entradomain") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".EntraDomain")) variable.Value = ssENEntraDomain; else variable.Optimized = true;
variable.SetFieldName("entradomain");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENEntraDomain.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENEntraDomain.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdEntraDomain) {
return ssENEntraDomain;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdEntraDomain.Key.AsGuid) {
return ssENEntraDomain;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENEntraDomain.FillFromOther((IRecord) other.AttributeGet(IdEntraDomain));
}
} // RC_46822aff680dcd6a1139ef31b620e73d
/// <summary>
/// RecordList type <code>EntraDomainRecordList</code> that represents a record list of
///  <code>EntraDomain</code>
/// </summary>
public partial class RL_b0441d601c09b7041f829817d6d535c2 : GenericRecordList<RC_46822aff680dcd6a1139ef31b620e73d>, IEnumerable, IEnumerator {

protected override RC_46822aff680dcd6a1139ef31b620e73d GetElementDefaultValue() {
return new RC_46822aff680dcd6a1139ef31b620e73d();
}

public T[] ToArray<T>(Func<RC_46822aff680dcd6a1139ef31b620e73d, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_b0441d601c09b7041f829817d6d535c2 recordList, Func<RC_46822aff680dcd6a1139ef31b620e73d, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_b0441d601c09b7041f829817d6d535c2(RC_46822aff680dcd6a1139ef31b620e73d[] array) {
  RL_b0441d601c09b7041f829817d6d535c2 result = new RL_b0441d601c09b7041f829817d6d535c2();
result.InnerFromArray(array);
    return result;
}

public static RL_b0441d601c09b7041f829817d6d535c2 ToList<T>(T[] array, Func <T, RC_46822aff680dcd6a1139ef31b620e73d> converter) {
  RL_b0441d601c09b7041f829817d6d535c2 result = new RL_b0441d601c09b7041f829817d6d535c2();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_b0441d601c09b7041f829817d6d535c2 FromRestList<T>(RestList<T> restList, Func <T, RC_46822aff680dcd6a1139ef31b620e73d> converter) {
  RL_b0441d601c09b7041f829817d6d535c2 result = new RL_b0441d601c09b7041f829817d6d535c2();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_b0441d601c09b7041f829817d6d535c2() : base() {
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
protected override OSList<RC_46822aff680dcd6a1139ef31b620e73d> NewList() {
return new RL_b0441d601c09b7041f829817d6d535c2();
}


} // RL_b0441d601c09b7041f829817d6d535c2
}

