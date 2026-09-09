namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (MHy5TupvFUmAGXMZfzOKqA)
///  <code>RC_e33b49261cecfe02249fd0f5f57f5dbc</code> that represent
/// s <code>RequisitionAccConceptsRecord</code> <p>Description: </p>
/// </summary>
// Name: RequisitionAccConceptsRecord
public partial struct RC_e33b49261cecfe02249fd0f5f57f5dbc : ITypedRecord<RC_e33b49261cecfe02249fd0f5f57f5dbc> {
internal static readonly GlobalObjectKey IdRequisitionAccConcepts = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Jkk74+wcAv4kn9D19X9dvA");

public EN_e5ff66566e5f431d75aae3b3535726a7EntityRecord ssENRequisitionAccConcepts;


public static implicit operator EN_e5ff66566e5f431d75aae3b3535726a7EntityRecord( RC_e33b49261cecfe02249fd0f5f57f5dbc r) {
return r.ssENRequisitionAccConcepts;
}

public static implicit operator RC_e33b49261cecfe02249fd0f5f57f5dbc (EN_e5ff66566e5f431d75aae3b3535726a7EntityRecord r) {
RC_e33b49261cecfe02249fd0f5f57f5dbc res = new RC_e33b49261cecfe02249fd0f5f57f5dbc ();
res.ssENRequisitionAccConcepts = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENRequisitionAccConcepts.ChangedAttributes = value;
}
get {
    return ssENRequisitionAccConcepts.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_e33b49261cecfe02249fd0f5f57f5dbc() {
OptimizedAttributes = null;
ssENRequisitionAccConcepts = new EN_e5ff66566e5f431d75aae3b3535726a7EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(8,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENRequisitionAccConcepts.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENRequisitionAccConcepts.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENRequisitionAccConcepts.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENRequisitionAccConcepts.Read( r, ref index);
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
public void ReadIM(RC_e33b49261cecfe02249fd0f5f57f5dbc r) {
this = r;
}


public static bool operator == (RC_e33b49261cecfe02249fd0f5f57f5dbc a, RC_e33b49261cecfe02249fd0f5f57f5dbc b) {
if (a.ssENRequisitionAccConcepts != b.ssENRequisitionAccConcepts) return false;
return true;
}

public static bool operator != (RC_e33b49261cecfe02249fd0f5f57f5dbc a, RC_e33b49261cecfe02249fd0f5f57f5dbc b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_e33b49261cecfe02249fd0f5f57f5dbc)) return false;
return (this == (RC_e33b49261cecfe02249fd0f5f57f5dbc)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENRequisitionAccConcepts.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENRequisitionAccConcepts.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENRequisitionAccConcepts.InternalRecursiveSave();
}


public RC_e33b49261cecfe02249fd0f5f57f5dbc Duplicate() {
RC_e33b49261cecfe02249fd0f5f57f5dbc t;
t.ssENRequisitionAccConcepts = (EN_e5ff66566e5f431d75aae3b3535726a7EntityRecord)this.ssENRequisitionAccConcepts.Duplicate();
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
if (head == "requisitionaccconcepts") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RequisitionAccConcepts")) variable.Value = ssENRequisitionAccConcepts; else variable.Optimized = true;
variable.SetFieldName("requisitionaccconcepts");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENRequisitionAccConcepts.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENRequisitionAccConcepts.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdRequisitionAccConcepts) {
return ssENRequisitionAccConcepts;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdRequisitionAccConcepts.Key.AsGuid) {
return ssENRequisitionAccConcepts;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENRequisitionAccConcepts.FillFromOther((IRecord) other.AttributeGet(IdRequisitionAccConcepts));
}
} // RC_e33b49261cecfe02249fd0f5f57f5dbc
/// <summary>
/// RecordList type <code>RequisitionAccConceptsRecordList</code> that represents a record list of
///  <code>RequisitionAccConcepts</code>
/// </summary>
public partial class RL_67eeb6e2fea6e1fe75fd0bc7d38796a5 : GenericRecordList<RC_e33b49261cecfe02249fd0f5f57f5dbc>, IEnumerable, IEnumerator {

protected override RC_e33b49261cecfe02249fd0f5f57f5dbc GetElementDefaultValue() {
return new RC_e33b49261cecfe02249fd0f5f57f5dbc();
}

public T[] ToArray<T>(Func<RC_e33b49261cecfe02249fd0f5f57f5dbc, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_67eeb6e2fea6e1fe75fd0bc7d38796a5 recordList, Func<RC_e33b49261cecfe02249fd0f5f57f5dbc, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_67eeb6e2fea6e1fe75fd0bc7d38796a5(RC_e33b49261cecfe02249fd0f5f57f5dbc[] array) {
  RL_67eeb6e2fea6e1fe75fd0bc7d38796a5 result = new RL_67eeb6e2fea6e1fe75fd0bc7d38796a5();
result.InnerFromArray(array);
    return result;
}

public static RL_67eeb6e2fea6e1fe75fd0bc7d38796a5 ToList<T>(T[] array, Func <T, RC_e33b49261cecfe02249fd0f5f57f5dbc> converter) {
  RL_67eeb6e2fea6e1fe75fd0bc7d38796a5 result = new RL_67eeb6e2fea6e1fe75fd0bc7d38796a5();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_67eeb6e2fea6e1fe75fd0bc7d38796a5 FromRestList<T>(RestList<T> restList, Func <T, RC_e33b49261cecfe02249fd0f5f57f5dbc> converter) {
  RL_67eeb6e2fea6e1fe75fd0bc7d38796a5 result = new RL_67eeb6e2fea6e1fe75fd0bc7d38796a5();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_67eeb6e2fea6e1fe75fd0bc7d38796a5() : base() {
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
protected override OSList<RC_e33b49261cecfe02249fd0f5f57f5dbc> NewList() {
return new RL_67eeb6e2fea6e1fe75fd0bc7d38796a5();
}


} // RL_67eeb6e2fea6e1fe75fd0bc7d38796a5
}

