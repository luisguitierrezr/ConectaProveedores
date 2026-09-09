namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (Dt2yeB3gM0m+rI4z76+GJQ)
///  <code>RC_14fd6714905cc16780383cc2da86ee0d</code> that represents <code>InvoicePolizaRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: InvoicePolizaRecord
public partial struct RC_14fd6714905cc16780383cc2da86ee0d : ITypedRecord<RC_14fd6714905cc16780383cc2da86ee0d> {
internal static readonly GlobalObjectKey IdInvoicePoliza = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*FGf9FFyQZ8GAODzC2obuDQ");

public EN_40f7c2dd79fcf6f1dd71369cb12f9d79EntityRecord ssENInvoicePoliza;


public static implicit operator EN_40f7c2dd79fcf6f1dd71369cb12f9d79EntityRecord( RC_14fd6714905cc16780383cc2da86ee0d r) {
return r.ssENInvoicePoliza;
}

public static implicit operator RC_14fd6714905cc16780383cc2da86ee0d (EN_40f7c2dd79fcf6f1dd71369cb12f9d79EntityRecord r) {
RC_14fd6714905cc16780383cc2da86ee0d res = new RC_14fd6714905cc16780383cc2da86ee0d ();
res.ssENInvoicePoliza = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENInvoicePoliza.ChangedAttributes = value;
}
get {
    return ssENInvoicePoliza.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_14fd6714905cc16780383cc2da86ee0d() {
OptimizedAttributes = null;
ssENInvoicePoliza = new EN_40f7c2dd79fcf6f1dd71369cb12f9d79EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(9,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENInvoicePoliza.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENInvoicePoliza.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENInvoicePoliza.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENInvoicePoliza.Read( r, ref index);
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
public void ReadIM(RC_14fd6714905cc16780383cc2da86ee0d r) {
this = r;
}


public static bool operator == (RC_14fd6714905cc16780383cc2da86ee0d a, RC_14fd6714905cc16780383cc2da86ee0d b) {
if (a.ssENInvoicePoliza != b.ssENInvoicePoliza) return false;
return true;
}

public static bool operator != (RC_14fd6714905cc16780383cc2da86ee0d a, RC_14fd6714905cc16780383cc2da86ee0d b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_14fd6714905cc16780383cc2da86ee0d)) return false;
return (this == (RC_14fd6714905cc16780383cc2da86ee0d)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENInvoicePoliza.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENInvoicePoliza.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENInvoicePoliza.InternalRecursiveSave();
}


public RC_14fd6714905cc16780383cc2da86ee0d Duplicate() {
RC_14fd6714905cc16780383cc2da86ee0d t;
t.ssENInvoicePoliza = (EN_40f7c2dd79fcf6f1dd71369cb12f9d79EntityRecord)this.ssENInvoicePoliza.Duplicate();
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
if (head == "invoicepoliza") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoicePoliza")) variable.Value = ssENInvoicePoliza; else variable.Optimized = true;
variable.SetFieldName("invoicepoliza");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENInvoicePoliza.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENInvoicePoliza.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdInvoicePoliza) {
return ssENInvoicePoliza;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInvoicePoliza.Key.AsGuid) {
return ssENInvoicePoliza;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENInvoicePoliza.FillFromOther((IRecord) other.AttributeGet(IdInvoicePoliza));
}
} // RC_14fd6714905cc16780383cc2da86ee0d
/// <summary>
/// RecordList type <code>InvoicePolizaRecordList</code> that represents a record list of
///  <code>InvoicePoliza</code>
/// </summary>
public partial class RL_9f2cc0799550a1f105537904fd426c3d : GenericRecordList<RC_14fd6714905cc16780383cc2da86ee0d>, IEnumerable, IEnumerator {

protected override RC_14fd6714905cc16780383cc2da86ee0d GetElementDefaultValue() {
return new RC_14fd6714905cc16780383cc2da86ee0d();
}

public T[] ToArray<T>(Func<RC_14fd6714905cc16780383cc2da86ee0d, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_9f2cc0799550a1f105537904fd426c3d recordList, Func<RC_14fd6714905cc16780383cc2da86ee0d, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_9f2cc0799550a1f105537904fd426c3d(RC_14fd6714905cc16780383cc2da86ee0d[] array) {
  RL_9f2cc0799550a1f105537904fd426c3d result = new RL_9f2cc0799550a1f105537904fd426c3d();
result.InnerFromArray(array);
    return result;
}

public static RL_9f2cc0799550a1f105537904fd426c3d ToList<T>(T[] array, Func <T, RC_14fd6714905cc16780383cc2da86ee0d> converter) {
  RL_9f2cc0799550a1f105537904fd426c3d result = new RL_9f2cc0799550a1f105537904fd426c3d();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_9f2cc0799550a1f105537904fd426c3d FromRestList<T>(RestList<T> restList, Func <T, RC_14fd6714905cc16780383cc2da86ee0d> converter) {
  RL_9f2cc0799550a1f105537904fd426c3d result = new RL_9f2cc0799550a1f105537904fd426c3d();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_9f2cc0799550a1f105537904fd426c3d() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(9,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_14fd6714905cc16780383cc2da86ee0d> NewList() {
return new RL_9f2cc0799550a1f105537904fd426c3d();
}


} // RL_9f2cc0799550a1f105537904fd426c3d
}

