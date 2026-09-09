namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (LFMN+fz00UuCDg18wA9wLA)
///  <code>RC_b6220f9cda8becc85872c79fa9ac74d5</code> that represent
/// s <code>ProposalTempDataRecord</code> <p>Description: </p>
/// </summary>
// Name: ProposalTempDataRecord
public partial struct RC_b6220f9cda8becc85872c79fa9ac74d5 : ITypedRecord<RC_b6220f9cda8becc85872c79fa9ac74d5> {
internal static readonly GlobalObjectKey IdProposalTempData = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*nA8itovayOxYcsefqax01Q");

public ST_ba28fce29317fb1a65969ecb0fce5c4bStructure ssSTProposalTempData;


public static implicit operator ST_ba28fce29317fb1a65969ecb0fce5c4bStructure( RC_b6220f9cda8becc85872c79fa9ac74d5 r) {
return r.ssSTProposalTempData;
}

public static implicit operator RC_b6220f9cda8becc85872c79fa9ac74d5 (ST_ba28fce29317fb1a65969ecb0fce5c4bStructure r) {
RC_b6220f9cda8becc85872c79fa9ac74d5 res = new RC_b6220f9cda8becc85872c79fa9ac74d5 ();
res.ssSTProposalTempData = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_b6220f9cda8becc85872c79fa9ac74d5() {
OptimizedAttributes = null;
ssSTProposalTempData = new ST_ba28fce29317fb1a65969ecb0fce5c4bStructure();
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
    ssSTProposalTempData.OptimizedAttributes = value[0];
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
ssSTProposalTempData.Read( r, ref index);
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
public void ReadIM(RC_b6220f9cda8becc85872c79fa9ac74d5 r) {
this = r;
}


public static bool operator == (RC_b6220f9cda8becc85872c79fa9ac74d5 a, RC_b6220f9cda8becc85872c79fa9ac74d5 b) {
if (a.ssSTProposalTempData != b.ssSTProposalTempData) return false;
return true;
}

public static bool operator != (RC_b6220f9cda8becc85872c79fa9ac74d5 a, RC_b6220f9cda8becc85872c79fa9ac74d5 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_b6220f9cda8becc85872c79fa9ac74d5)) return false;
return (this == (RC_b6220f9cda8becc85872c79fa9ac74d5)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTProposalTempData.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTProposalTempData.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTProposalTempData.InternalRecursiveSave();
}


public RC_b6220f9cda8becc85872c79fa9ac74d5 Duplicate() {
RC_b6220f9cda8becc85872c79fa9ac74d5 t;
t.ssSTProposalTempData = (ST_ba28fce29317fb1a65969ecb0fce5c4bStructure)this.ssSTProposalTempData.Duplicate();
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
if (head == "proposaltempdata") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ProposalTempData")) variable.Value = ssSTProposalTempData; else variable.Optimized = true;
variable.SetFieldName("proposaltempdata");
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
if (key == IdProposalTempData) {
return ssSTProposalTempData;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdProposalTempData.Key.AsGuid) {
return ssSTProposalTempData;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTProposalTempData.FillFromOther((IRecord) other.AttributeGet(IdProposalTempData));
}
} // RC_b6220f9cda8becc85872c79fa9ac74d5
/// <summary>
/// RecordList type <code>ProposalTempDataRecordList</code> that represents a record list of
///  <code>ProposalTempData</code>
/// </summary>
public partial class RL_3b5780fe9ddff0fa9972cda064372e47 : GenericRecordList<RC_b6220f9cda8becc85872c79fa9ac74d5>, IEnumerable, IEnumerator {

protected override RC_b6220f9cda8becc85872c79fa9ac74d5 GetElementDefaultValue() {
return new RC_b6220f9cda8becc85872c79fa9ac74d5();
}

public T[] ToArray<T>(Func<RC_b6220f9cda8becc85872c79fa9ac74d5, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_3b5780fe9ddff0fa9972cda064372e47 recordList, Func<RC_b6220f9cda8becc85872c79fa9ac74d5, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_3b5780fe9ddff0fa9972cda064372e47(RC_b6220f9cda8becc85872c79fa9ac74d5[] array) {
  RL_3b5780fe9ddff0fa9972cda064372e47 result = new RL_3b5780fe9ddff0fa9972cda064372e47();
result.InnerFromArray(array);
    return result;
}

public static RL_3b5780fe9ddff0fa9972cda064372e47 ToList<T>(T[] array, Func <T, RC_b6220f9cda8becc85872c79fa9ac74d5> converter) {
  RL_3b5780fe9ddff0fa9972cda064372e47 result = new RL_3b5780fe9ddff0fa9972cda064372e47();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_3b5780fe9ddff0fa9972cda064372e47 FromRestList<T>(RestList<T> restList, Func <T, RC_b6220f9cda8becc85872c79fa9ac74d5> converter) {
  RL_3b5780fe9ddff0fa9972cda064372e47 result = new RL_3b5780fe9ddff0fa9972cda064372e47();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_3b5780fe9ddff0fa9972cda064372e47() : base() {
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
protected override OSList<RC_b6220f9cda8becc85872c79fa9ac74d5> NewList() {
return new RL_3b5780fe9ddff0fa9972cda064372e47();
}


} // RL_3b5780fe9ddff0fa9972cda064372e47
}

