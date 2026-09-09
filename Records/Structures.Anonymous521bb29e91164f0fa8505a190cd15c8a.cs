namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (nrIbUhaRD0+oUFoZDNFcig)
///  <code>RC_d0bb3f44a292c80efaf69b83c1f1cc02</code> that represents <code>OrdersToConsultRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: OrdersToConsultRecord
public partial struct RC_d0bb3f44a292c80efaf69b83c1f1cc02 : ITypedRecord<RC_d0bb3f44a292c80efaf69b83c1f1cc02> {
internal static readonly GlobalObjectKey IdOrdersToConsult = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*RD+70JKiDsj69puDwfHMAg");

public ST_1f6eb08d8d1b200d3c17cf7efe59c4dcStructure ssSTOrdersToConsult;


public static implicit operator ST_1f6eb08d8d1b200d3c17cf7efe59c4dcStructure( RC_d0bb3f44a292c80efaf69b83c1f1cc02 r) {
return r.ssSTOrdersToConsult;
}

public static implicit operator RC_d0bb3f44a292c80efaf69b83c1f1cc02 (ST_1f6eb08d8d1b200d3c17cf7efe59c4dcStructure r) {
RC_d0bb3f44a292c80efaf69b83c1f1cc02 res = new RC_d0bb3f44a292c80efaf69b83c1f1cc02 ();
res.ssSTOrdersToConsult = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_d0bb3f44a292c80efaf69b83c1f1cc02() {
OptimizedAttributes = null;
ssSTOrdersToConsult = new ST_1f6eb08d8d1b200d3c17cf7efe59c4dcStructure();
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
    ssSTOrdersToConsult.OptimizedAttributes = value[0];
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
ssSTOrdersToConsult.Read( r, ref index);
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
public void ReadIM(RC_d0bb3f44a292c80efaf69b83c1f1cc02 r) {
this = r;
}


public static bool operator == (RC_d0bb3f44a292c80efaf69b83c1f1cc02 a, RC_d0bb3f44a292c80efaf69b83c1f1cc02 b) {
if (a.ssSTOrdersToConsult != b.ssSTOrdersToConsult) return false;
return true;
}

public static bool operator != (RC_d0bb3f44a292c80efaf69b83c1f1cc02 a, RC_d0bb3f44a292c80efaf69b83c1f1cc02 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_d0bb3f44a292c80efaf69b83c1f1cc02)) return false;
return (this == (RC_d0bb3f44a292c80efaf69b83c1f1cc02)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTOrdersToConsult.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTOrdersToConsult.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTOrdersToConsult.InternalRecursiveSave();
}


public RC_d0bb3f44a292c80efaf69b83c1f1cc02 Duplicate() {
RC_d0bb3f44a292c80efaf69b83c1f1cc02 t;
t.ssSTOrdersToConsult = (ST_1f6eb08d8d1b200d3c17cf7efe59c4dcStructure)this.ssSTOrdersToConsult.Duplicate();
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
if (head == "orderstoconsult") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrdersToConsult")) variable.Value = ssSTOrdersToConsult; else variable.Optimized = true;
variable.SetFieldName("orderstoconsult");
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
if (key == IdOrdersToConsult) {
return ssSTOrdersToConsult;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOrdersToConsult.Key.AsGuid) {
return ssSTOrdersToConsult;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTOrdersToConsult.FillFromOther((IRecord) other.AttributeGet(IdOrdersToConsult));
}
} // RC_d0bb3f44a292c80efaf69b83c1f1cc02
/// <summary>
/// RecordList type <code>OrdersToConsultRecordList</code> that represents a record list of
///  <code>OrdersToConsult</code>
/// </summary>
public partial class RL_ba8a6fa9497761be975dfc71dab6b632 : GenericRecordList<RC_d0bb3f44a292c80efaf69b83c1f1cc02>, IEnumerable, IEnumerator {

protected override RC_d0bb3f44a292c80efaf69b83c1f1cc02 GetElementDefaultValue() {
return new RC_d0bb3f44a292c80efaf69b83c1f1cc02();
}

public T[] ToArray<T>(Func<RC_d0bb3f44a292c80efaf69b83c1f1cc02, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_ba8a6fa9497761be975dfc71dab6b632 recordList, Func<RC_d0bb3f44a292c80efaf69b83c1f1cc02, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_ba8a6fa9497761be975dfc71dab6b632(RC_d0bb3f44a292c80efaf69b83c1f1cc02[] array) {
  RL_ba8a6fa9497761be975dfc71dab6b632 result = new RL_ba8a6fa9497761be975dfc71dab6b632();
result.InnerFromArray(array);
    return result;
}

public static RL_ba8a6fa9497761be975dfc71dab6b632 ToList<T>(T[] array, Func <T, RC_d0bb3f44a292c80efaf69b83c1f1cc02> converter) {
  RL_ba8a6fa9497761be975dfc71dab6b632 result = new RL_ba8a6fa9497761be975dfc71dab6b632();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_ba8a6fa9497761be975dfc71dab6b632 FromRestList<T>(RestList<T> restList, Func <T, RC_d0bb3f44a292c80efaf69b83c1f1cc02> converter) {
  RL_ba8a6fa9497761be975dfc71dab6b632 result = new RL_ba8a6fa9497761be975dfc71dab6b632();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_ba8a6fa9497761be975dfc71dab6b632() : base() {
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
protected override OSList<RC_d0bb3f44a292c80efaf69b83c1f1cc02> NewList() {
return new RL_ba8a6fa9497761be975dfc71dab6b632();
}


} // RL_ba8a6fa9497761be975dfc71dab6b632
}

