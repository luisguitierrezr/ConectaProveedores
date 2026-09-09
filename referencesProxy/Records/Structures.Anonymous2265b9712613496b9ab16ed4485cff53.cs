namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (cbllIhMma0masW7USFz_Uw)
///  <code>RC_460505b3c40cd288809440d484d2598e</code> that represents <code>ItemSM_RMRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: ItemSM_RMRecord
public partial struct RC_460505b3c40cd288809440d484d2598e : ITypedRecord<RC_460505b3c40cd288809440d484d2598e> {
internal static readonly GlobalObjectKey IdItemSM_RM = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*swUFRgzEiNKAlEDUhNJZjg");

public ST_c6a30ab803e481b26794961e87468e52Structure ssSTItemSM_RM;


public static implicit operator ST_c6a30ab803e481b26794961e87468e52Structure( RC_460505b3c40cd288809440d484d2598e r) {
return r.ssSTItemSM_RM;
}

public static implicit operator RC_460505b3c40cd288809440d484d2598e (ST_c6a30ab803e481b26794961e87468e52Structure r) {
RC_460505b3c40cd288809440d484d2598e res = new RC_460505b3c40cd288809440d484d2598e ();
res.ssSTItemSM_RM = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_460505b3c40cd288809440d484d2598e() {
OptimizedAttributes = null;
ssSTItemSM_RM = new ST_c6a30ab803e481b26794961e87468e52Structure();
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
    ssSTItemSM_RM.OptimizedAttributes = value[0];
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
ssSTItemSM_RM.Read( r, ref index);
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
public void ReadIM(RC_460505b3c40cd288809440d484d2598e r) {
this = r;
}


public static bool operator == (RC_460505b3c40cd288809440d484d2598e a, RC_460505b3c40cd288809440d484d2598e b) {
if (a.ssSTItemSM_RM != b.ssSTItemSM_RM) return false;
return true;
}

public static bool operator != (RC_460505b3c40cd288809440d484d2598e a, RC_460505b3c40cd288809440d484d2598e b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_460505b3c40cd288809440d484d2598e)) return false;
return (this == (RC_460505b3c40cd288809440d484d2598e)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTItemSM_RM.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTItemSM_RM.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTItemSM_RM.InternalRecursiveSave();
}


public RC_460505b3c40cd288809440d484d2598e Duplicate() {
RC_460505b3c40cd288809440d484d2598e t;
t.ssSTItemSM_RM = (ST_c6a30ab803e481b26794961e87468e52Structure)this.ssSTItemSM_RM.Duplicate();
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
if (head == "itemsm_rm") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ItemSM_RM")) variable.Value = ssSTItemSM_RM; else variable.Optimized = true;
variable.SetFieldName("itemsm_rm");
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
if (key == IdItemSM_RM) {
return ssSTItemSM_RM;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdItemSM_RM.Key.AsGuid) {
return ssSTItemSM_RM;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTItemSM_RM.FillFromOther((IRecord) other.AttributeGet(IdItemSM_RM));
}
} // RC_460505b3c40cd288809440d484d2598e
/// <summary>
/// RecordList type <code>ItemSM_RMRecordList</code> that represents a record list of
///  <code>ItemSM_RM</code>
/// </summary>
public partial class RL_7304cc1206056a072c65a8e053fce004 : GenericRecordList<RC_460505b3c40cd288809440d484d2598e>, IEnumerable, IEnumerator {

protected override RC_460505b3c40cd288809440d484d2598e GetElementDefaultValue() {
return new RC_460505b3c40cd288809440d484d2598e();
}

public T[] ToArray<T>(Func<RC_460505b3c40cd288809440d484d2598e, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_7304cc1206056a072c65a8e053fce004 recordList, Func<RC_460505b3c40cd288809440d484d2598e, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_7304cc1206056a072c65a8e053fce004(RC_460505b3c40cd288809440d484d2598e[] array) {
  RL_7304cc1206056a072c65a8e053fce004 result = new RL_7304cc1206056a072c65a8e053fce004();
result.InnerFromArray(array);
    return result;
}

public static RL_7304cc1206056a072c65a8e053fce004 ToList<T>(T[] array, Func <T, RC_460505b3c40cd288809440d484d2598e> converter) {
  RL_7304cc1206056a072c65a8e053fce004 result = new RL_7304cc1206056a072c65a8e053fce004();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_7304cc1206056a072c65a8e053fce004 FromRestList<T>(RestList<T> restList, Func <T, RC_460505b3c40cd288809440d484d2598e> converter) {
  RL_7304cc1206056a072c65a8e053fce004 result = new RL_7304cc1206056a072c65a8e053fce004();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_7304cc1206056a072c65a8e053fce004() : base() {
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
protected override OSList<RC_460505b3c40cd288809440d484d2598e> NewList() {
return new RL_7304cc1206056a072c65a8e053fce004();
}


} // RL_7304cc1206056a072c65a8e053fce004
}

