namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (WFW0CHgztkaC4vhyP6PGEw)
///  <code>RC_c3fffd52ae72b7942dcb46e5cfbb700b</code> that represents <code>PI_ITEM_EM_RMRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: PI_ITEM_EM_RMRecord
public partial struct RC_c3fffd52ae72b7942dcb46e5cfbb700b : ITypedRecord<RC_c3fffd52ae72b7942dcb46e5cfbb700b> {
internal static readonly GlobalObjectKey IdPI_ITEM_EM_RM = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Uv3_w3KulLcty0blz7twCw");

public ST_9689a124a3af07dbe86be1015d9b7bb1Structure ssSTPI_ITEM_EM_RM;


public static implicit operator ST_9689a124a3af07dbe86be1015d9b7bb1Structure( RC_c3fffd52ae72b7942dcb46e5cfbb700b r) {
return r.ssSTPI_ITEM_EM_RM;
}

public static implicit operator RC_c3fffd52ae72b7942dcb46e5cfbb700b (ST_9689a124a3af07dbe86be1015d9b7bb1Structure r) {
RC_c3fffd52ae72b7942dcb46e5cfbb700b res = new RC_c3fffd52ae72b7942dcb46e5cfbb700b ();
res.ssSTPI_ITEM_EM_RM = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_c3fffd52ae72b7942dcb46e5cfbb700b() {
OptimizedAttributes = null;
ssSTPI_ITEM_EM_RM = new ST_9689a124a3af07dbe86be1015d9b7bb1Structure();
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
    ssSTPI_ITEM_EM_RM.OptimizedAttributes = value[0];
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
ssSTPI_ITEM_EM_RM.Read( r, ref index);
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
public void ReadIM(RC_c3fffd52ae72b7942dcb46e5cfbb700b r) {
this = r;
}


public static bool operator == (RC_c3fffd52ae72b7942dcb46e5cfbb700b a, RC_c3fffd52ae72b7942dcb46e5cfbb700b b) {
if (a.ssSTPI_ITEM_EM_RM != b.ssSTPI_ITEM_EM_RM) return false;
return true;
}

public static bool operator != (RC_c3fffd52ae72b7942dcb46e5cfbb700b a, RC_c3fffd52ae72b7942dcb46e5cfbb700b b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_c3fffd52ae72b7942dcb46e5cfbb700b)) return false;
return (this == (RC_c3fffd52ae72b7942dcb46e5cfbb700b)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTPI_ITEM_EM_RM.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTPI_ITEM_EM_RM.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTPI_ITEM_EM_RM.InternalRecursiveSave();
}


public RC_c3fffd52ae72b7942dcb46e5cfbb700b Duplicate() {
RC_c3fffd52ae72b7942dcb46e5cfbb700b t;
t.ssSTPI_ITEM_EM_RM = (ST_9689a124a3af07dbe86be1015d9b7bb1Structure)this.ssSTPI_ITEM_EM_RM.Duplicate();
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
if (head == "pi_item_em_rm") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PI_ITEM_EM_RM")) variable.Value = ssSTPI_ITEM_EM_RM; else variable.Optimized = true;
variable.SetFieldName("pi_item_em_rm");
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
if (key == IdPI_ITEM_EM_RM) {
return ssSTPI_ITEM_EM_RM;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdPI_ITEM_EM_RM.Key.AsGuid) {
return ssSTPI_ITEM_EM_RM;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTPI_ITEM_EM_RM.FillFromOther((IRecord) other.AttributeGet(IdPI_ITEM_EM_RM));
}
} // RC_c3fffd52ae72b7942dcb46e5cfbb700b
/// <summary>
/// RecordList type <code>PI_ITEM_EM_RMRecordList</code> that represents a record list of
///  <code>PI_ITEM_EM_RM</code>
/// </summary>
public partial class RL_a57e883e58ecc97c9f8998afc43fabc9 : GenericRecordList<RC_c3fffd52ae72b7942dcb46e5cfbb700b>, IEnumerable, IEnumerator {

protected override RC_c3fffd52ae72b7942dcb46e5cfbb700b GetElementDefaultValue() {
return new RC_c3fffd52ae72b7942dcb46e5cfbb700b();
}

public T[] ToArray<T>(Func<RC_c3fffd52ae72b7942dcb46e5cfbb700b, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_a57e883e58ecc97c9f8998afc43fabc9 recordList, Func<RC_c3fffd52ae72b7942dcb46e5cfbb700b, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_a57e883e58ecc97c9f8998afc43fabc9(RC_c3fffd52ae72b7942dcb46e5cfbb700b[] array) {
  RL_a57e883e58ecc97c9f8998afc43fabc9 result = new RL_a57e883e58ecc97c9f8998afc43fabc9();
result.InnerFromArray(array);
    return result;
}

public static RL_a57e883e58ecc97c9f8998afc43fabc9 ToList<T>(T[] array, Func <T, RC_c3fffd52ae72b7942dcb46e5cfbb700b> converter) {
  RL_a57e883e58ecc97c9f8998afc43fabc9 result = new RL_a57e883e58ecc97c9f8998afc43fabc9();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_a57e883e58ecc97c9f8998afc43fabc9 FromRestList<T>(RestList<T> restList, Func <T, RC_c3fffd52ae72b7942dcb46e5cfbb700b> converter) {
  RL_a57e883e58ecc97c9f8998afc43fabc9 result = new RL_a57e883e58ecc97c9f8998afc43fabc9();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_a57e883e58ecc97c9f8998afc43fabc9() : base() {
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
protected override OSList<RC_c3fffd52ae72b7942dcb46e5cfbb700b> NewList() {
return new RL_a57e883e58ecc97c9f8998afc43fabc9();
}


} // RL_a57e883e58ecc97c9f8998afc43fabc9
}

