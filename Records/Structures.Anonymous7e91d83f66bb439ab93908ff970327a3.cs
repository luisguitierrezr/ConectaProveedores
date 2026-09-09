namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (P9iRfrtmmkO5OQj_lwMnow)
///  <code>RC_8c5142d0fa3763f0e03a67182ad7f367</code> that represent
/// s <code>DocumentExtrationPeriodRecord</code> <p>Description: </p>
/// </summary>
// Name: DocumentExtrationPeriodRecord
public partial struct RC_8c5142d0fa3763f0e03a67182ad7f367 : ITypedRecord<RC_8c5142d0fa3763f0e03a67182ad7f367> {
internal static readonly GlobalObjectKey IdDocumentExtrationPeriod = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*0EJRjDf68GPgOmcYKtfzZw");

public ST_3071806a59ac2d49d464c40254dbb5f2Structure ssSTDocumentExtrationPeriod;


public static implicit operator ST_3071806a59ac2d49d464c40254dbb5f2Structure( RC_8c5142d0fa3763f0e03a67182ad7f367 r) {
return r.ssSTDocumentExtrationPeriod;
}

public static implicit operator RC_8c5142d0fa3763f0e03a67182ad7f367 (ST_3071806a59ac2d49d464c40254dbb5f2Structure r) {
RC_8c5142d0fa3763f0e03a67182ad7f367 res = new RC_8c5142d0fa3763f0e03a67182ad7f367 ();
res.ssSTDocumentExtrationPeriod = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_8c5142d0fa3763f0e03a67182ad7f367() {
OptimizedAttributes = null;
ssSTDocumentExtrationPeriod = new ST_3071806a59ac2d49d464c40254dbb5f2Structure();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = null;
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    ssSTDocumentExtrationPeriod.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = null;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssSTDocumentExtrationPeriod.Read( r, ref index);
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
public void ReadIM(RC_8c5142d0fa3763f0e03a67182ad7f367 r) {
this = r;
}


public static bool operator == (RC_8c5142d0fa3763f0e03a67182ad7f367 a, RC_8c5142d0fa3763f0e03a67182ad7f367 b) {
if (a.ssSTDocumentExtrationPeriod != b.ssSTDocumentExtrationPeriod) return false;
return true;
}

public static bool operator != (RC_8c5142d0fa3763f0e03a67182ad7f367 a, RC_8c5142d0fa3763f0e03a67182ad7f367 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_8c5142d0fa3763f0e03a67182ad7f367)) return false;
return (this == (RC_8c5142d0fa3763f0e03a67182ad7f367)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTDocumentExtrationPeriod.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTDocumentExtrationPeriod.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTDocumentExtrationPeriod.InternalRecursiveSave();
}


public RC_8c5142d0fa3763f0e03a67182ad7f367 Duplicate() {
RC_8c5142d0fa3763f0e03a67182ad7f367 t;
t.ssSTDocumentExtrationPeriod = (ST_3071806a59ac2d49d464c40254dbb5f2Structure)this.ssSTDocumentExtrationPeriod.Duplicate();
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
if (head == "documentextrationperiod") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DocumentExtrationPeriod")) variable.Value = ssSTDocumentExtrationPeriod; else variable.Optimized = true;
variable.SetFieldName("documentextrationperiod");
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
if (key == IdDocumentExtrationPeriod) {
return ssSTDocumentExtrationPeriod;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdDocumentExtrationPeriod.Key.AsGuid) {
return ssSTDocumentExtrationPeriod;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTDocumentExtrationPeriod.FillFromOther((IRecord) other.AttributeGet(IdDocumentExtrationPeriod));
}
} // RC_8c5142d0fa3763f0e03a67182ad7f367
/// <summary>
/// RecordList type <code>DocumentExtrationPeriodRecordList</code> that represents a record list of
///  <code>DocumentExtrationPeriod</code>
/// </summary>
public partial class RL_48050ae766dbc87fdae4f3cdf62237ea : GenericRecordList<RC_8c5142d0fa3763f0e03a67182ad7f367>, IEnumerable, IEnumerator {

protected override RC_8c5142d0fa3763f0e03a67182ad7f367 GetElementDefaultValue() {
return new RC_8c5142d0fa3763f0e03a67182ad7f367();
}

public T[] ToArray<T>(Func<RC_8c5142d0fa3763f0e03a67182ad7f367, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_48050ae766dbc87fdae4f3cdf62237ea recordList, Func<RC_8c5142d0fa3763f0e03a67182ad7f367, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_48050ae766dbc87fdae4f3cdf62237ea(RC_8c5142d0fa3763f0e03a67182ad7f367[] array) {
  RL_48050ae766dbc87fdae4f3cdf62237ea result = new RL_48050ae766dbc87fdae4f3cdf62237ea();
result.InnerFromArray(array);
    return result;
}

public static RL_48050ae766dbc87fdae4f3cdf62237ea ToList<T>(T[] array, Func <T, RC_8c5142d0fa3763f0e03a67182ad7f367> converter) {
  RL_48050ae766dbc87fdae4f3cdf62237ea result = new RL_48050ae766dbc87fdae4f3cdf62237ea();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_48050ae766dbc87fdae4f3cdf62237ea FromRestList<T>(RestList<T> restList, Func <T, RC_8c5142d0fa3763f0e03a67182ad7f367> converter) {
  RL_48050ae766dbc87fdae4f3cdf62237ea result = new RL_48050ae766dbc87fdae4f3cdf62237ea();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_48050ae766dbc87fdae4f3cdf62237ea() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = null;
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_8c5142d0fa3763f0e03a67182ad7f367> NewList() {
return new RL_48050ae766dbc87fdae4f3cdf62237ea();
}


} // RL_48050ae766dbc87fdae4f3cdf62237ea
}

