namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (FLWmArLsb06ihFes8c9AgQ)
///  <code>RC_f0854a122622e23d0af9485eff078f73</code> that represents <code>PI_ITEM_SM_RMRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: PI_ITEM_SM_RMRecord
public partial struct RC_f0854a122622e23d0af9485eff078f73 : ITypedRecord<RC_f0854a122622e23d0af9485eff078f73> {
internal static readonly GlobalObjectKey IdPI_ITEM_SM_RM = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*EkqF8CImPeIK+Uhe_wePcw");

public ST_145adfa176456c38d3985aa98c524483Structure ssSTPI_ITEM_SM_RM;


public static implicit operator ST_145adfa176456c38d3985aa98c524483Structure( RC_f0854a122622e23d0af9485eff078f73 r) {
return r.ssSTPI_ITEM_SM_RM;
}

public static implicit operator RC_f0854a122622e23d0af9485eff078f73 (ST_145adfa176456c38d3985aa98c524483Structure r) {
RC_f0854a122622e23d0af9485eff078f73 res = new RC_f0854a122622e23d0af9485eff078f73 ();
res.ssSTPI_ITEM_SM_RM = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_f0854a122622e23d0af9485eff078f73() {
OptimizedAttributes = null;
ssSTPI_ITEM_SM_RM = new ST_145adfa176456c38d3985aa98c524483Structure();
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
    ssSTPI_ITEM_SM_RM.OptimizedAttributes = value[0];
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
ssSTPI_ITEM_SM_RM.Read( r, ref index);
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
public void ReadIM(RC_f0854a122622e23d0af9485eff078f73 r) {
this = r;
}


public static bool operator == (RC_f0854a122622e23d0af9485eff078f73 a, RC_f0854a122622e23d0af9485eff078f73 b) {
if (a.ssSTPI_ITEM_SM_RM != b.ssSTPI_ITEM_SM_RM) return false;
return true;
}

public static bool operator != (RC_f0854a122622e23d0af9485eff078f73 a, RC_f0854a122622e23d0af9485eff078f73 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_f0854a122622e23d0af9485eff078f73)) return false;
return (this == (RC_f0854a122622e23d0af9485eff078f73)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTPI_ITEM_SM_RM.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTPI_ITEM_SM_RM.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTPI_ITEM_SM_RM.InternalRecursiveSave();
}


public RC_f0854a122622e23d0af9485eff078f73 Duplicate() {
RC_f0854a122622e23d0af9485eff078f73 t;
t.ssSTPI_ITEM_SM_RM = (ST_145adfa176456c38d3985aa98c524483Structure)this.ssSTPI_ITEM_SM_RM.Duplicate();
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
if (head == "pi_item_sm_rm") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PI_ITEM_SM_RM")) variable.Value = ssSTPI_ITEM_SM_RM; else variable.Optimized = true;
variable.SetFieldName("pi_item_sm_rm");
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
if (key == IdPI_ITEM_SM_RM) {
return ssSTPI_ITEM_SM_RM;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdPI_ITEM_SM_RM.Key.AsGuid) {
return ssSTPI_ITEM_SM_RM;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTPI_ITEM_SM_RM.FillFromOther((IRecord) other.AttributeGet(IdPI_ITEM_SM_RM));
}
} // RC_f0854a122622e23d0af9485eff078f73
/// <summary>
/// RecordList type <code>PI_ITEM_SM_RMRecordList</code> that represents a record list of
///  <code>PI_ITEM_SM_RM</code>
/// </summary>
public partial class RL_8902114e73d13e0bf76bf59528b04faf : GenericRecordList<RC_f0854a122622e23d0af9485eff078f73>, IEnumerable, IEnumerator {

protected override RC_f0854a122622e23d0af9485eff078f73 GetElementDefaultValue() {
return new RC_f0854a122622e23d0af9485eff078f73();
}

public T[] ToArray<T>(Func<RC_f0854a122622e23d0af9485eff078f73, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_8902114e73d13e0bf76bf59528b04faf recordList, Func<RC_f0854a122622e23d0af9485eff078f73, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_8902114e73d13e0bf76bf59528b04faf(RC_f0854a122622e23d0af9485eff078f73[] array) {
  RL_8902114e73d13e0bf76bf59528b04faf result = new RL_8902114e73d13e0bf76bf59528b04faf();
result.InnerFromArray(array);
    return result;
}

public static RL_8902114e73d13e0bf76bf59528b04faf ToList<T>(T[] array, Func <T, RC_f0854a122622e23d0af9485eff078f73> converter) {
  RL_8902114e73d13e0bf76bf59528b04faf result = new RL_8902114e73d13e0bf76bf59528b04faf();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_8902114e73d13e0bf76bf59528b04faf FromRestList<T>(RestList<T> restList, Func <T, RC_f0854a122622e23d0af9485eff078f73> converter) {
  RL_8902114e73d13e0bf76bf59528b04faf result = new RL_8902114e73d13e0bf76bf59528b04faf();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_8902114e73d13e0bf76bf59528b04faf() : base() {
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
protected override OSList<RC_f0854a122622e23d0af9485eff078f73> NewList() {
return new RL_8902114e73d13e0bf76bf59528b04faf();
}


} // RL_8902114e73d13e0bf76bf59528b04faf
}

