namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (SPk2JDaZkEOYN3fUrrzT+g)
///  <code>RC_0ac1b5c675d1742c0ea797802ee62592</code> that represent
/// s <code>UserApplicationRoleTempByConceptRecord</code> <p>Description: </p>
/// </summary>
// Name: UserApplicationRoleTempByConceptRecord
public partial struct RC_0ac1b5c675d1742c0ea797802ee62592 : ITypedRecord<RC_0ac1b5c675d1742c0ea797802ee62592> {
internal static readonly GlobalObjectKey IdUserApplicationRoleTempByConcept = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*xrXBCtF1LHQOp5eALuYlkg");

public EN_22cf7e5edc270b9d6ff62fe7b88e1c45EntityRecord ssENUserApplicationRoleTempByConcept;


public static implicit operator EN_22cf7e5edc270b9d6ff62fe7b88e1c45EntityRecord( RC_0ac1b5c675d1742c0ea797802ee62592 r) {
return r.ssENUserApplicationRoleTempByConcept;
}

public static implicit operator RC_0ac1b5c675d1742c0ea797802ee62592 (EN_22cf7e5edc270b9d6ff62fe7b88e1c45EntityRecord r) {
RC_0ac1b5c675d1742c0ea797802ee62592 res = new RC_0ac1b5c675d1742c0ea797802ee62592 ();
res.ssENUserApplicationRoleTempByConcept = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENUserApplicationRoleTempByConcept.ChangedAttributes = value;
}
get {
    return ssENUserApplicationRoleTempByConcept.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_0ac1b5c675d1742c0ea797802ee62592() {
OptimizedAttributes = null;
ssENUserApplicationRoleTempByConcept = new EN_22cf7e5edc270b9d6ff62fe7b88e1c45EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(4,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENUserApplicationRoleTempByConcept.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENUserApplicationRoleTempByConcept.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENUserApplicationRoleTempByConcept.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENUserApplicationRoleTempByConcept.Read( r, ref index);
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
public void ReadIM(RC_0ac1b5c675d1742c0ea797802ee62592 r) {
this = r;
}


public static bool operator == (RC_0ac1b5c675d1742c0ea797802ee62592 a, RC_0ac1b5c675d1742c0ea797802ee62592 b) {
if (a.ssENUserApplicationRoleTempByConcept != b.ssENUserApplicationRoleTempByConcept) return false;
return true;
}

public static bool operator != (RC_0ac1b5c675d1742c0ea797802ee62592 a, RC_0ac1b5c675d1742c0ea797802ee62592 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_0ac1b5c675d1742c0ea797802ee62592)) return false;
return (this == (RC_0ac1b5c675d1742c0ea797802ee62592)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENUserApplicationRoleTempByConcept.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENUserApplicationRoleTempByConcept.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENUserApplicationRoleTempByConcept.InternalRecursiveSave();
}


public RC_0ac1b5c675d1742c0ea797802ee62592 Duplicate() {
RC_0ac1b5c675d1742c0ea797802ee62592 t;
t.ssENUserApplicationRoleTempByConcept = (EN_22cf7e5edc270b9d6ff62fe7b88e1c45EntityRecord)this.ssENUserApplicationRoleTempByConcept.Duplicate();
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
if (head == "userapplicationroletempbyconcept") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UserApplicationRoleTempByConcept")) variable.Value = ssENUserApplicationRoleTempByConcept; else variable.Optimized = true;
variable.SetFieldName("userapplicationroletempbyconcept");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENUserApplicationRoleTempByConcept.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENUserApplicationRoleTempByConcept.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdUserApplicationRoleTempByConcept) {
return ssENUserApplicationRoleTempByConcept;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdUserApplicationRoleTempByConcept.Key.AsGuid) {
return ssENUserApplicationRoleTempByConcept;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENUserApplicationRoleTempByConcept.FillFromOther((IRecord) other.AttributeGet(IdUserApplicationRoleTempByConcept));
}
} // RC_0ac1b5c675d1742c0ea797802ee62592
/// <summary>
/// RecordList type <code>UserApplicationRoleTempByConceptRecordList</code> that represents a record
///  list of <code>UserApplicationRoleTempByConcept</code>
/// </summary>
public partial class RL_cec0549afd388ab0909b825565ba629a : GenericRecordList<RC_0ac1b5c675d1742c0ea797802ee62592>, IEnumerable, IEnumerator {

protected override RC_0ac1b5c675d1742c0ea797802ee62592 GetElementDefaultValue() {
return new RC_0ac1b5c675d1742c0ea797802ee62592();
}

public T[] ToArray<T>(Func<RC_0ac1b5c675d1742c0ea797802ee62592, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_cec0549afd388ab0909b825565ba629a recordList, Func<RC_0ac1b5c675d1742c0ea797802ee62592, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_cec0549afd388ab0909b825565ba629a(RC_0ac1b5c675d1742c0ea797802ee62592[] array) {
  RL_cec0549afd388ab0909b825565ba629a result = new RL_cec0549afd388ab0909b825565ba629a();
result.InnerFromArray(array);
    return result;
}

public static RL_cec0549afd388ab0909b825565ba629a ToList<T>(T[] array, Func <T, RC_0ac1b5c675d1742c0ea797802ee62592> converter) {
  RL_cec0549afd388ab0909b825565ba629a result = new RL_cec0549afd388ab0909b825565ba629a();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_cec0549afd388ab0909b825565ba629a FromRestList<T>(RestList<T> restList, Func <T, RC_0ac1b5c675d1742c0ea797802ee62592> converter) {
  RL_cec0549afd388ab0909b825565ba629a result = new RL_cec0549afd388ab0909b825565ba629a();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_cec0549afd388ab0909b825565ba629a() : base() {
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
protected override OSList<RC_0ac1b5c675d1742c0ea797802ee62592> NewList() {
return new RL_cec0549afd388ab0909b825565ba629a();
}


} // RL_cec0549afd388ab0909b825565ba629a
}

