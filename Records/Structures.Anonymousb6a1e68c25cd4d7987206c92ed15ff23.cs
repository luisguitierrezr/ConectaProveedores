namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (jOahts0leU2HIGyS7RX_Iw)
///  <code>RC_baf165956df9a5eebdc813b129b5fb73</code> that represent
/// s <code>MainAccConceptsSubAccConceptsRecord</code> <p>Description: </p>
/// </summary>
// Name: MainAccConceptsSubAccConceptsRecord
public partial struct RC_baf165956df9a5eebdc813b129b5fb73 : ITypedRecord<RC_baf165956df9a5eebdc813b129b5fb73> {
internal static readonly GlobalObjectKey IdMainAccConcepts = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*qRcWOYmQmJxgPPr9KDIJnA");
internal static readonly GlobalObjectKey IdSubAccConcepts = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*E8+3RaDrN7TQ+QXVimauCA");

public EN_e5ff66566e5f431d75aae3b3535726a7EntityRecord ssENMainAccConcepts;

public RL_eb1e4f883a237aab70c23418de71281c ssRLSubAccConcepts;


public BitArray OptimizedAttributes;

public RC_baf165956df9a5eebdc813b129b5fb73() {
OptimizedAttributes = null;
ssENMainAccConcepts = new EN_e5ff66566e5f431d75aae3b3535726a7EntityRecord();
ssRLSubAccConcepts = new RL_eb1e4f883a237aab70c23418de71281c();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(8,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENMainAccConcepts.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENMainAccConcepts.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENMainAccConcepts.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENMainAccConcepts.Read( r, ref index);
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
public void ReadIM(RC_baf165956df9a5eebdc813b129b5fb73 r) {
this = r;
}


public static bool operator == (RC_baf165956df9a5eebdc813b129b5fb73 a, RC_baf165956df9a5eebdc813b129b5fb73 b) {
if (a.ssENMainAccConcepts != b.ssENMainAccConcepts) return false;
if (a.ssRLSubAccConcepts != b.ssRLSubAccConcepts) return false;
return true;
}

public static bool operator != (RC_baf165956df9a5eebdc813b129b5fb73 a, RC_baf165956df9a5eebdc813b129b5fb73 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_baf165956df9a5eebdc813b129b5fb73)) return false;
return (this == (RC_baf165956df9a5eebdc813b129b5fb73)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENMainAccConcepts.GetHashCode()
 ^ ssRLSubAccConcepts.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENMainAccConcepts.RecursiveReset();
ssRLSubAccConcepts.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENMainAccConcepts.InternalRecursiveSave();
ssRLSubAccConcepts.InternalRecursiveSave();
}


public RC_baf165956df9a5eebdc813b129b5fb73 Duplicate() {
RC_baf165956df9a5eebdc813b129b5fb73 t;
t.ssENMainAccConcepts = (EN_e5ff66566e5f431d75aae3b3535726a7EntityRecord)this.ssENMainAccConcepts.Duplicate();
t.ssRLSubAccConcepts = (RL_eb1e4f883a237aab70c23418de71281c)this.ssRLSubAccConcepts.Duplicate();
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
if (head == "mainaccconcepts") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".MainAccConcepts")) variable.Value = ssENMainAccConcepts; else variable.Optimized = true;
variable.SetFieldName("mainaccconcepts");
} else if (head == "subaccconcepts") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SubAccConcepts")) variable.Value = ssRLSubAccConcepts; else variable.Optimized = true;
variable.SetFieldName("subaccconcepts");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdMainAccConcepts) {
return ssENMainAccConcepts;
}
if (key == IdSubAccConcepts) {
return ssRLSubAccConcepts;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdMainAccConcepts.Key.AsGuid) {
return ssENMainAccConcepts;
}
if (attributeKey == IdSubAccConcepts.Key.AsGuid) {
return ssRLSubAccConcepts;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENMainAccConcepts.FillFromOther((IRecord) other.AttributeGet(IdMainAccConcepts));
ssRLSubAccConcepts = new RL_eb1e4f883a237aab70c23418de71281c();
ssRLSubAccConcepts.FillFromOther((IOSList) other.AttributeGet(IdSubAccConcepts));
}
} // RC_baf165956df9a5eebdc813b129b5fb73
/// <summary>
/// RecordList type <code>MainAccConceptsSubAccConceptsRecordList</code> that represents a record list
///  of <code>RequisitionAccConcepts, RequisitionAccConceptsList</code>
/// </summary>
public partial class RL_8bdc512050df4431cbd454ae455bbf06 : GenericRecordList<RC_baf165956df9a5eebdc813b129b5fb73>, IEnumerable, IEnumerator {

protected override RC_baf165956df9a5eebdc813b129b5fb73 GetElementDefaultValue() {
return new RC_baf165956df9a5eebdc813b129b5fb73();
}

public T[] ToArray<T>(Func<RC_baf165956df9a5eebdc813b129b5fb73, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_8bdc512050df4431cbd454ae455bbf06 recordList, Func<RC_baf165956df9a5eebdc813b129b5fb73, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_8bdc512050df4431cbd454ae455bbf06(RC_baf165956df9a5eebdc813b129b5fb73[] array) {
  RL_8bdc512050df4431cbd454ae455bbf06 result = new RL_8bdc512050df4431cbd454ae455bbf06();
result.InnerFromArray(array);
    return result;
}

public static RL_8bdc512050df4431cbd454ae455bbf06 ToList<T>(T[] array, Func <T, RC_baf165956df9a5eebdc813b129b5fb73> converter) {
  RL_8bdc512050df4431cbd454ae455bbf06 result = new RL_8bdc512050df4431cbd454ae455bbf06();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_8bdc512050df4431cbd454ae455bbf06 FromRestList<T>(RestList<T> restList, Func <T, RC_baf165956df9a5eebdc813b129b5fb73> converter) {
  RL_8bdc512050df4431cbd454ae455bbf06 result = new RL_8bdc512050df4431cbd454ae455bbf06();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_8bdc512050df4431cbd454ae455bbf06() : base() {
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
protected override OSList<RC_baf165956df9a5eebdc813b129b5fb73> NewList() {
return new RL_8bdc512050df4431cbd454ae455bbf06();
}


} // RL_8bdc512050df4431cbd454ae455bbf06
}

