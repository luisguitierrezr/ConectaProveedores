namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (oQEzr7YEmEm5CAYdeH4Y0w)
///  <code>RC_bafaeb2b78c21ab9180984166a89be29</code> that represent
/// s <code>ForeignInvoiceUsResultRecord</code> <p>Description: </p>
/// </summary>
// Name: ForeignInvoiceUsResultRecord
public partial struct RC_bafaeb2b78c21ab9180984166a89be29 : ITypedRecord<RC_bafaeb2b78c21ab9180984166a89be29>, OutSystems.Application.Extensibility.DataTypes.IStructure {
internal static readonly GlobalObjectKey IdForeignInvoiceUsResult = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*K+v6usJ4uRoYCYQWaom+KQ");

public ST_6f620840109ac6f721328b723ec0152cStructure ssSTForeignInvoiceUsResult;


public static implicit operator ST_6f620840109ac6f721328b723ec0152cStructure( RC_bafaeb2b78c21ab9180984166a89be29 r) {
return r.ssSTForeignInvoiceUsResult;
}

public static implicit operator RC_bafaeb2b78c21ab9180984166a89be29 (ST_6f620840109ac6f721328b723ec0152cStructure r) {
RC_bafaeb2b78c21ab9180984166a89be29 res = new RC_bafaeb2b78c21ab9180984166a89be29 ();
res.ssSTForeignInvoiceUsResult = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_bafaeb2b78c21ab9180984166a89be29() {
OptimizedAttributes = null;
ssSTForeignInvoiceUsResult = new ST_6f620840109ac6f721328b723ec0152cStructure();
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
    ssSTForeignInvoiceUsResult.OptimizedAttributes = value[0];
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
ssSTForeignInvoiceUsResult.Read( r, ref index);
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
public void ReadIM(RC_bafaeb2b78c21ab9180984166a89be29 r) {
this = r;
}


public static bool operator == (RC_bafaeb2b78c21ab9180984166a89be29 a, RC_bafaeb2b78c21ab9180984166a89be29 b) {
if (a.ssSTForeignInvoiceUsResult != b.ssSTForeignInvoiceUsResult) return false;
return true;
}

public static bool operator != (RC_bafaeb2b78c21ab9180984166a89be29 a, RC_bafaeb2b78c21ab9180984166a89be29 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_bafaeb2b78c21ab9180984166a89be29)) return false;
return (this == (RC_bafaeb2b78c21ab9180984166a89be29)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTForeignInvoiceUsResult.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTForeignInvoiceUsResult.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTForeignInvoiceUsResult.InternalRecursiveSave();
}


public RC_bafaeb2b78c21ab9180984166a89be29 Duplicate() {
RC_bafaeb2b78c21ab9180984166a89be29 t;
t.ssSTForeignInvoiceUsResult = (ST_6f620840109ac6f721328b723ec0152cStructure)this.ssSTForeignInvoiceUsResult.Duplicate();
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
if (head == "foreigninvoiceusresult") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ForeignInvoiceUsResult")) variable.Value = ssSTForeignInvoiceUsResult; else variable.Optimized = true;
variable.SetFieldName("foreigninvoiceusresult");
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
if (key == IdForeignInvoiceUsResult) {
return ssSTForeignInvoiceUsResult;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdForeignInvoiceUsResult.Key.AsGuid) {
return ssSTForeignInvoiceUsResult;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTForeignInvoiceUsResult.FillFromOther((IRecord) other.AttributeGet(IdForeignInvoiceUsResult));
}
public void CopyFrom(OutSystems.Application.Extensibility.DataTypes.IRecord other) {
if (other == null) return;
ssSTForeignInvoiceUsResult.CopyFrom((OutSystems.Application.Extensibility.DataTypes.IRecord) other.GetAttribute(IdForeignInvoiceUsResult.Key.AsGuid));
}
} // RC_bafaeb2b78c21ab9180984166a89be29
/// <summary>
/// RecordList type <code>ForeignInvoiceUsResultRecordList</code> that represents a record list of
///  <code>ForeignInvoiceUsResult</code>
/// </summary>
public partial class RL_2bc55c89a997fa7baa39c9a218a6dd5d : GenericRecordList<RC_bafaeb2b78c21ab9180984166a89be29>, IEnumerable, IEnumerator {

protected override RC_bafaeb2b78c21ab9180984166a89be29 GetElementDefaultValue() {
return new RC_bafaeb2b78c21ab9180984166a89be29();
}

public T[] ToArray<T>(Func<RC_bafaeb2b78c21ab9180984166a89be29, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_2bc55c89a997fa7baa39c9a218a6dd5d recordList, Func<RC_bafaeb2b78c21ab9180984166a89be29, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_2bc55c89a997fa7baa39c9a218a6dd5d(RC_bafaeb2b78c21ab9180984166a89be29[] array) {
  RL_2bc55c89a997fa7baa39c9a218a6dd5d result = new RL_2bc55c89a997fa7baa39c9a218a6dd5d();
result.InnerFromArray(array);
    return result;
}

public static RL_2bc55c89a997fa7baa39c9a218a6dd5d ToList<T>(T[] array, Func <T, RC_bafaeb2b78c21ab9180984166a89be29> converter) {
  RL_2bc55c89a997fa7baa39c9a218a6dd5d result = new RL_2bc55c89a997fa7baa39c9a218a6dd5d();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_2bc55c89a997fa7baa39c9a218a6dd5d FromRestList<T>(RestList<T> restList, Func <T, RC_bafaeb2b78c21ab9180984166a89be29> converter) {
  RL_2bc55c89a997fa7baa39c9a218a6dd5d result = new RL_2bc55c89a997fa7baa39c9a218a6dd5d();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_2bc55c89a997fa7baa39c9a218a6dd5d() : base() {
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
protected override OSList<RC_bafaeb2b78c21ab9180984166a89be29> NewList() {
return new RL_2bc55c89a997fa7baa39c9a218a6dd5d();
}


} // RL_2bc55c89a997fa7baa39c9a218a6dd5d
}

