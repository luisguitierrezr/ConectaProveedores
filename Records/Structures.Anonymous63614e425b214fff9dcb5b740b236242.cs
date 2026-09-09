namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (Qk5hYyFb_0+dy1t0CyNiQg)
///  <code>RC_cdb29de40f41bea5403aac7edb2d6159</code> that represent
/// s <code>MainAccConceptSubAccConceptsRecord</code> <p>Description: </p>
/// </summary>
// Name: MainAccConceptSubAccConceptsRecord
public partial struct RC_cdb29de40f41bea5403aac7edb2d6159 : ITypedRecord<RC_cdb29de40f41bea5403aac7edb2d6159> {
internal static readonly GlobalObjectKey IdMainAccConcept = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*QaMoAITP1pWqob6fz4A0WQ");
internal static readonly GlobalObjectKey IdSubAccConcepts = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*E8+3RaDrN7TQ+QXVimauCA");

public EN_e5ff66566e5f431d75aae3b3535726a7EntityRecord ssENMainAccConcept;

public RL_eb1e4f883a237aab70c23418de71281c ssRLSubAccConcepts;


public BitArray OptimizedAttributes;

public RC_cdb29de40f41bea5403aac7edb2d6159() {
OptimizedAttributes = null;
ssENMainAccConcept = new EN_e5ff66566e5f431d75aae3b3535726a7EntityRecord();
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
    ssENMainAccConcept.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENMainAccConcept.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENMainAccConcept.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENMainAccConcept.Read( r, ref index);
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
public void ReadIM(RC_cdb29de40f41bea5403aac7edb2d6159 r) {
this = r;
}


public static bool operator == (RC_cdb29de40f41bea5403aac7edb2d6159 a, RC_cdb29de40f41bea5403aac7edb2d6159 b) {
if (a.ssENMainAccConcept != b.ssENMainAccConcept) return false;
if (a.ssRLSubAccConcepts != b.ssRLSubAccConcepts) return false;
return true;
}

public static bool operator != (RC_cdb29de40f41bea5403aac7edb2d6159 a, RC_cdb29de40f41bea5403aac7edb2d6159 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_cdb29de40f41bea5403aac7edb2d6159)) return false;
return (this == (RC_cdb29de40f41bea5403aac7edb2d6159)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENMainAccConcept.GetHashCode()
 ^ ssRLSubAccConcepts.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENMainAccConcept.RecursiveReset();
ssRLSubAccConcepts.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENMainAccConcept.InternalRecursiveSave();
ssRLSubAccConcepts.InternalRecursiveSave();
}


public RC_cdb29de40f41bea5403aac7edb2d6159 Duplicate() {
RC_cdb29de40f41bea5403aac7edb2d6159 t;
t.ssENMainAccConcept = (EN_e5ff66566e5f431d75aae3b3535726a7EntityRecord)this.ssENMainAccConcept.Duplicate();
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
if (head == "mainaccconcept") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".MainAccConcept")) variable.Value = ssENMainAccConcept; else variable.Optimized = true;
variable.SetFieldName("mainaccconcept");
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
if (key == IdMainAccConcept) {
return ssENMainAccConcept;
}
if (key == IdSubAccConcepts) {
return ssRLSubAccConcepts;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdMainAccConcept.Key.AsGuid) {
return ssENMainAccConcept;
}
if (attributeKey == IdSubAccConcepts.Key.AsGuid) {
return ssRLSubAccConcepts;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENMainAccConcept.FillFromOther((IRecord) other.AttributeGet(IdMainAccConcept));
ssRLSubAccConcepts = new RL_eb1e4f883a237aab70c23418de71281c();
ssRLSubAccConcepts.FillFromOther((IOSList) other.AttributeGet(IdSubAccConcepts));
}
} // RC_cdb29de40f41bea5403aac7edb2d6159
/// <summary>
/// RecordList type <code>MainAccConceptSubAccConceptsRecordList</code> that represents a record list
///  of <code>RequisitionAccConcepts, RequisitionAccConceptsList</code>
/// </summary>
public partial class RL_7bc99b65b26c07fea257770a2ff33c72 : GenericRecordList<RC_cdb29de40f41bea5403aac7edb2d6159>, IEnumerable, IEnumerator {

protected override RC_cdb29de40f41bea5403aac7edb2d6159 GetElementDefaultValue() {
return new RC_cdb29de40f41bea5403aac7edb2d6159();
}

public T[] ToArray<T>(Func<RC_cdb29de40f41bea5403aac7edb2d6159, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_7bc99b65b26c07fea257770a2ff33c72 recordList, Func<RC_cdb29de40f41bea5403aac7edb2d6159, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_7bc99b65b26c07fea257770a2ff33c72(RC_cdb29de40f41bea5403aac7edb2d6159[] array) {
  RL_7bc99b65b26c07fea257770a2ff33c72 result = new RL_7bc99b65b26c07fea257770a2ff33c72();
result.InnerFromArray(array);
    return result;
}

public static RL_7bc99b65b26c07fea257770a2ff33c72 ToList<T>(T[] array, Func <T, RC_cdb29de40f41bea5403aac7edb2d6159> converter) {
  RL_7bc99b65b26c07fea257770a2ff33c72 result = new RL_7bc99b65b26c07fea257770a2ff33c72();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_7bc99b65b26c07fea257770a2ff33c72 FromRestList<T>(RestList<T> restList, Func <T, RC_cdb29de40f41bea5403aac7edb2d6159> converter) {
  RL_7bc99b65b26c07fea257770a2ff33c72 result = new RL_7bc99b65b26c07fea257770a2ff33c72();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_7bc99b65b26c07fea257770a2ff33c72() : base() {
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
protected override OSList<RC_cdb29de40f41bea5403aac7edb2d6159> NewList() {
return new RL_7bc99b65b26c07fea257770a2ff33c72();
}


} // RL_7bc99b65b26c07fea257770a2ff33c72
}

