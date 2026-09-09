namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (punK3HBCf0OatOwh0zc6Lg)
///  <code>RC_152a5bcdbf970bfba2a0da40766a2168</code> that represent
/// s <code>InvoiceExtendedMoreChargesRecord</code> <p>Description: </p>
/// </summary>
// Name: InvoiceExtendedMoreChargesRecord
public partial struct RC_152a5bcdbf970bfba2a0da40766a2168 : ITypedRecord<RC_152a5bcdbf970bfba2a0da40766a2168> {
internal static readonly GlobalObjectKey IdInvoiceExtendedMoreCharges = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*zVsqFZe_+wuioNpAdmohaA");

public EN_a9440c310249b67518f0615139b4c690EntityRecord ssENInvoiceExtendedMoreCharges;


public static implicit operator EN_a9440c310249b67518f0615139b4c690EntityRecord( RC_152a5bcdbf970bfba2a0da40766a2168 r) {
return r.ssENInvoiceExtendedMoreCharges;
}

public static implicit operator RC_152a5bcdbf970bfba2a0da40766a2168 (EN_a9440c310249b67518f0615139b4c690EntityRecord r) {
RC_152a5bcdbf970bfba2a0da40766a2168 res = new RC_152a5bcdbf970bfba2a0da40766a2168 ();
res.ssENInvoiceExtendedMoreCharges = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENInvoiceExtendedMoreCharges.ChangedAttributes = value;
}
get {
    return ssENInvoiceExtendedMoreCharges.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_152a5bcdbf970bfba2a0da40766a2168() {
OptimizedAttributes = null;
ssENInvoiceExtendedMoreCharges = new EN_a9440c310249b67518f0615139b4c690EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(4,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENInvoiceExtendedMoreCharges.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENInvoiceExtendedMoreCharges.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENInvoiceExtendedMoreCharges.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENInvoiceExtendedMoreCharges.Read( r, ref index);
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
public void ReadIM(RC_152a5bcdbf970bfba2a0da40766a2168 r) {
this = r;
}


public static bool operator == (RC_152a5bcdbf970bfba2a0da40766a2168 a, RC_152a5bcdbf970bfba2a0da40766a2168 b) {
if (a.ssENInvoiceExtendedMoreCharges != b.ssENInvoiceExtendedMoreCharges) return false;
return true;
}

public static bool operator != (RC_152a5bcdbf970bfba2a0da40766a2168 a, RC_152a5bcdbf970bfba2a0da40766a2168 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_152a5bcdbf970bfba2a0da40766a2168)) return false;
return (this == (RC_152a5bcdbf970bfba2a0da40766a2168)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENInvoiceExtendedMoreCharges.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENInvoiceExtendedMoreCharges.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENInvoiceExtendedMoreCharges.InternalRecursiveSave();
}


public RC_152a5bcdbf970bfba2a0da40766a2168 Duplicate() {
RC_152a5bcdbf970bfba2a0da40766a2168 t;
t.ssENInvoiceExtendedMoreCharges = (EN_a9440c310249b67518f0615139b4c690EntityRecord)this.ssENInvoiceExtendedMoreCharges.Duplicate();
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
if (head == "invoiceextendedmorecharges") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceExtendedMoreCharges")) variable.Value = ssENInvoiceExtendedMoreCharges; else variable.Optimized = true;
variable.SetFieldName("invoiceextendedmorecharges");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENInvoiceExtendedMoreCharges.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENInvoiceExtendedMoreCharges.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdInvoiceExtendedMoreCharges) {
return ssENInvoiceExtendedMoreCharges;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInvoiceExtendedMoreCharges.Key.AsGuid) {
return ssENInvoiceExtendedMoreCharges;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENInvoiceExtendedMoreCharges.FillFromOther((IRecord) other.AttributeGet(IdInvoiceExtendedMoreCharges));
}
} // RC_152a5bcdbf970bfba2a0da40766a2168
/// <summary>
/// RecordList type <code>InvoiceExtendedMoreChargesRecordList</code> that represents a record list of
///  <code>InvoiceExtendedMoreCharges</code>
/// </summary>
public partial class RL_ef088826c46241557fb82e7c7f21d334 : GenericRecordList<RC_152a5bcdbf970bfba2a0da40766a2168>, IEnumerable, IEnumerator {

protected override RC_152a5bcdbf970bfba2a0da40766a2168 GetElementDefaultValue() {
return new RC_152a5bcdbf970bfba2a0da40766a2168();
}

public T[] ToArray<T>(Func<RC_152a5bcdbf970bfba2a0da40766a2168, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_ef088826c46241557fb82e7c7f21d334 recordList, Func<RC_152a5bcdbf970bfba2a0da40766a2168, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_ef088826c46241557fb82e7c7f21d334(RC_152a5bcdbf970bfba2a0da40766a2168[] array) {
  RL_ef088826c46241557fb82e7c7f21d334 result = new RL_ef088826c46241557fb82e7c7f21d334();
result.InnerFromArray(array);
    return result;
}

public static RL_ef088826c46241557fb82e7c7f21d334 ToList<T>(T[] array, Func <T, RC_152a5bcdbf970bfba2a0da40766a2168> converter) {
  RL_ef088826c46241557fb82e7c7f21d334 result = new RL_ef088826c46241557fb82e7c7f21d334();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_ef088826c46241557fb82e7c7f21d334 FromRestList<T>(RestList<T> restList, Func <T, RC_152a5bcdbf970bfba2a0da40766a2168> converter) {
  RL_ef088826c46241557fb82e7c7f21d334 result = new RL_ef088826c46241557fb82e7c7f21d334();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_ef088826c46241557fb82e7c7f21d334() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(4,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_152a5bcdbf970bfba2a0da40766a2168> NewList() {
return new RL_ef088826c46241557fb82e7c7f21d334();
}


} // RL_ef088826c46241557fb82e7c7f21d334
}

