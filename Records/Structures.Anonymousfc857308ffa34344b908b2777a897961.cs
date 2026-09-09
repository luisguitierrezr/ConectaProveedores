namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (CHOF_KP_REO5CLJ3eol5YQ)
///  <code>RC_cad676a01e44d775889bfdee9f2eda1f</code> that represent
/// s <code>InvoiceInvoiceStatusRecord</code> <p>Description: </p>
/// </summary>
// Name: InvoiceInvoiceStatusRecord
public partial struct RC_cad676a01e44d775889bfdee9f2eda1f : ITypedRecord<RC_cad676a01e44d775889bfdee9f2eda1f> {
internal static readonly GlobalObjectKey IdInvoice = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*a5jFBMcyL4IDPJM89xuWvQ");
internal static readonly GlobalObjectKey IdInvoiceStatus = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*xRfbbmO_L0X0rCTUGZGpQA");

public EN_d1d0320db36efbb094ad0082361435a0EntityRecord ssENInvoice;

public EN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord ssENInvoiceStatus;


public BitArray OptimizedAttributes;

public RC_cad676a01e44d775889bfdee9f2eda1f() {
OptimizedAttributes = null;
ssENInvoice = new EN_d1d0320db36efbb094ad0082361435a0EntityRecord();
ssENInvoiceStatus = new EN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[2];
    all[0] = new BitArray(24,false);
    all[1] = new BitArray(7,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENInvoice.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENInvoiceStatus.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    }else{
    ssENInvoice.OptimizedAttributes = value[0];
    ssENInvoiceStatus.OptimizedAttributes = value[1];
    }
}
get{
    BitArray[] all = new BitArray[2];
    all[0] = ssENInvoice.OptimizedAttributes;
    all[1] = ssENInvoiceStatus.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENInvoice.Read( r, ref index);
ssENInvoiceStatus.Read( r, ref index);
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
public void ReadIM(RC_cad676a01e44d775889bfdee9f2eda1f r) {
this = r;
}


public static bool operator == (RC_cad676a01e44d775889bfdee9f2eda1f a, RC_cad676a01e44d775889bfdee9f2eda1f b) {
if (a.ssENInvoice != b.ssENInvoice) return false;
if (a.ssENInvoiceStatus != b.ssENInvoiceStatus) return false;
return true;
}

public static bool operator != (RC_cad676a01e44d775889bfdee9f2eda1f a, RC_cad676a01e44d775889bfdee9f2eda1f b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_cad676a01e44d775889bfdee9f2eda1f)) return false;
return (this == (RC_cad676a01e44d775889bfdee9f2eda1f)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENInvoice.GetHashCode()
 ^ ssENInvoiceStatus.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENInvoice.RecursiveReset();
ssENInvoiceStatus.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENInvoice.InternalRecursiveSave();
ssENInvoiceStatus.InternalRecursiveSave();
}


public RC_cad676a01e44d775889bfdee9f2eda1f Duplicate() {
RC_cad676a01e44d775889bfdee9f2eda1f t;
t.ssENInvoice = (EN_d1d0320db36efbb094ad0082361435a0EntityRecord)this.ssENInvoice.Duplicate();
t.ssENInvoiceStatus = (EN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord)this.ssENInvoiceStatus.Duplicate();
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
if (head == "invoice") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Invoice")) variable.Value = ssENInvoice; else variable.Optimized = true;
variable.SetFieldName("invoice");
} else if (head == "invoicestatus") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceStatus")) variable.Value = ssENInvoiceStatus; else variable.Optimized = true;
variable.SetFieldName("invoicestatus");
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
if (key == IdInvoice) {
return ssENInvoice;
}
if (key == IdInvoiceStatus) {
return ssENInvoiceStatus;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInvoice.Key.AsGuid) {
return ssENInvoice;
}
if (attributeKey == IdInvoiceStatus.Key.AsGuid) {
return ssENInvoiceStatus;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENInvoice.FillFromOther((IRecord) other.AttributeGet(IdInvoice));
ssENInvoiceStatus.FillFromOther((IRecord) other.AttributeGet(IdInvoiceStatus));
}
} // RC_cad676a01e44d775889bfdee9f2eda1f
/// <summary>
/// RecordList type <code>InvoiceInvoiceStatusRecordList</code> that represents a record list of
///  <code>Invoice, InvoiceStatus</code>
/// </summary>
public partial class RL_4c91727910427c345e342c96f50fbfbf : GenericRecordList<RC_cad676a01e44d775889bfdee9f2eda1f>, IEnumerable, IEnumerator {

protected override RC_cad676a01e44d775889bfdee9f2eda1f GetElementDefaultValue() {
return new RC_cad676a01e44d775889bfdee9f2eda1f();
}

public T[] ToArray<T>(Func<RC_cad676a01e44d775889bfdee9f2eda1f, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_4c91727910427c345e342c96f50fbfbf recordList, Func<RC_cad676a01e44d775889bfdee9f2eda1f, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_4c91727910427c345e342c96f50fbfbf(RC_cad676a01e44d775889bfdee9f2eda1f[] array) {
  RL_4c91727910427c345e342c96f50fbfbf result = new RL_4c91727910427c345e342c96f50fbfbf();
result.InnerFromArray(array);
    return result;
}

public static RL_4c91727910427c345e342c96f50fbfbf ToList<T>(T[] array, Func <T, RC_cad676a01e44d775889bfdee9f2eda1f> converter) {
  RL_4c91727910427c345e342c96f50fbfbf result = new RL_4c91727910427c345e342c96f50fbfbf();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_4c91727910427c345e342c96f50fbfbf FromRestList<T>(RestList<T> restList, Func <T, RC_cad676a01e44d775889bfdee9f2eda1f> converter) {
  RL_4c91727910427c345e342c96f50fbfbf result = new RL_4c91727910427c345e342c96f50fbfbf();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_4c91727910427c345e342c96f50fbfbf() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[2];
def[0] = new BitArray(24,false);
def[1] = new BitArray(7,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_cad676a01e44d775889bfdee9f2eda1f> NewList() {
return new RL_4c91727910427c345e342c96f50fbfbf();
}


} // RL_4c91727910427c345e342c96f50fbfbf
}

