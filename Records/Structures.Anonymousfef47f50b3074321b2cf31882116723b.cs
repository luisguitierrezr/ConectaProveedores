namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (UH_0_gezIUOyzzGIIRZyOw)
///  <code>RC_2c7478516bbd3eed6a35183496a9f500</code> that represent
/// s
///  <code>InvoiceInvoiceExtendedReceiverInvoiceExtendedCartaPorteInvoiceExtendedIssuerInvoiceAccounting
/// InvoiceExtendedRecord</code> <p>Description: </p>
/// </summary>
// Name: InvoiceInvoiceExtendedReceiverInvoiceExtendedCartaPorteInvoiceExtendedIssuerInvoiceAccountingInvoiceExtendedRecord
public partial struct RC_2c7478516bbd3eed6a35183496a9f500 : ITypedRecord<RC_2c7478516bbd3eed6a35183496a9f500> {
internal static readonly GlobalObjectKey IdInvoice = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*a5jFBMcyL4IDPJM89xuWvQ");
internal static readonly GlobalObjectKey IdInvoiceExtendedReceiver = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*uBhvRvdwk4GYmQQSj8LRXA");
internal static readonly GlobalObjectKey IdInvoiceExtendedCartaPorte = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*FDG4ebwnTL7k7L4EK_A3cw");
internal static readonly GlobalObjectKey IdInvoiceExtendedIssuer = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*uN_tvHBWlarkSqBJGU8rfA");
internal static readonly GlobalObjectKey IdInvoiceAccounting = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*PqiYw9GniAlua+aT9tB4Zw");
internal static readonly GlobalObjectKey IdInvoiceExtended = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*BfHj+9QKT_Og4KFfiKVocw");

public EN_d1d0320db36efbb094ad0082361435a0EntityRecord ssENInvoice;

public EN_b0c20b1f1237d3e4f4e5e432cd60cb6aEntityRecord ssENInvoiceExtendedReceiver;

public EN_9bd576a05df3846c52ce88a606aff414EntityRecord ssENInvoiceExtendedCartaPorte;

public EN_1ca446167f1a5fee035306f622895668EntityRecord ssENInvoiceExtendedIssuer;

public EN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord ssENInvoiceAccounting;

public EN_f81a3d226103fd013068b8763798067aEntityRecord ssENInvoiceExtended;


public BitArray OptimizedAttributes;

public RC_2c7478516bbd3eed6a35183496a9f500() {
OptimizedAttributes = null;
ssENInvoice = new EN_d1d0320db36efbb094ad0082361435a0EntityRecord();
ssENInvoiceExtendedReceiver = new EN_b0c20b1f1237d3e4f4e5e432cd60cb6aEntityRecord();
ssENInvoiceExtendedCartaPorte = new EN_9bd576a05df3846c52ce88a606aff414EntityRecord();
ssENInvoiceExtendedIssuer = new EN_1ca446167f1a5fee035306f622895668EntityRecord();
ssENInvoiceAccounting = new EN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord();
ssENInvoiceExtended = new EN_f81a3d226103fd013068b8763798067aEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[6];
    all[0] = new BitArray(24,false);
    all[1] = new BitArray(5,false);
    all[2] = new BitArray(7,false);
    all[3] = new BitArray(5,false);
    all[4] = new BitArray(21,false);
    all[5] = new BitArray(19,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENInvoice.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENInvoiceExtendedReceiver.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENInvoiceExtendedCartaPorte.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENInvoiceExtendedIssuer.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    ssENInvoiceAccounting.OptimizedAttributes = GetDefaultOptimizedValues()[4];
    ssENInvoiceExtended.OptimizedAttributes = GetDefaultOptimizedValues()[5];
    }else{
    ssENInvoice.OptimizedAttributes = value[0];
    ssENInvoiceExtendedReceiver.OptimizedAttributes = value[1];
    ssENInvoiceExtendedCartaPorte.OptimizedAttributes = value[2];
    ssENInvoiceExtendedIssuer.OptimizedAttributes = value[3];
    ssENInvoiceAccounting.OptimizedAttributes = value[4];
    ssENInvoiceExtended.OptimizedAttributes = value[5];
    }
}
get{
    BitArray[] all = new BitArray[6];
    all[0] = ssENInvoice.OptimizedAttributes;
    all[1] = ssENInvoiceExtendedReceiver.OptimizedAttributes;
    all[2] = ssENInvoiceExtendedCartaPorte.OptimizedAttributes;
    all[3] = ssENInvoiceExtendedIssuer.OptimizedAttributes;
    all[4] = ssENInvoiceAccounting.OptimizedAttributes;
    all[5] = ssENInvoiceExtended.OptimizedAttributes;
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
ssENInvoiceExtendedReceiver.Read( r, ref index);
ssENInvoiceExtendedCartaPorte.Read( r, ref index);
ssENInvoiceExtendedIssuer.Read( r, ref index);
ssENInvoiceAccounting.Read( r, ref index);
ssENInvoiceExtended.Read( r, ref index);
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
public void ReadIM(RC_2c7478516bbd3eed6a35183496a9f500 r) {
this = r;
}


public static bool operator == (RC_2c7478516bbd3eed6a35183496a9f500 a, RC_2c7478516bbd3eed6a35183496a9f500 b) {
if (a.ssENInvoice != b.ssENInvoice) return false;
if (a.ssENInvoiceExtendedReceiver != b.ssENInvoiceExtendedReceiver) return false;
if (a.ssENInvoiceExtendedCartaPorte != b.ssENInvoiceExtendedCartaPorte) return false;
if (a.ssENInvoiceExtendedIssuer != b.ssENInvoiceExtendedIssuer) return false;
if (a.ssENInvoiceAccounting != b.ssENInvoiceAccounting) return false;
if (a.ssENInvoiceExtended != b.ssENInvoiceExtended) return false;
return true;
}

public static bool operator != (RC_2c7478516bbd3eed6a35183496a9f500 a, RC_2c7478516bbd3eed6a35183496a9f500 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_2c7478516bbd3eed6a35183496a9f500)) return false;
return (this == (RC_2c7478516bbd3eed6a35183496a9f500)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENInvoice.GetHashCode()
 ^ ssENInvoiceExtendedReceiver.GetHashCode()
 ^ ssENInvoiceExtendedCartaPorte.GetHashCode()
 ^ ssENInvoiceExtendedIssuer.GetHashCode()
 ^ ssENInvoiceAccounting.GetHashCode()
 ^ ssENInvoiceExtended.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENInvoice.RecursiveReset();
ssENInvoiceExtendedReceiver.RecursiveReset();
ssENInvoiceExtendedCartaPorte.RecursiveReset();
ssENInvoiceExtendedIssuer.RecursiveReset();
ssENInvoiceAccounting.RecursiveReset();
ssENInvoiceExtended.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENInvoice.InternalRecursiveSave();
ssENInvoiceExtendedReceiver.InternalRecursiveSave();
ssENInvoiceExtendedCartaPorte.InternalRecursiveSave();
ssENInvoiceExtendedIssuer.InternalRecursiveSave();
ssENInvoiceAccounting.InternalRecursiveSave();
ssENInvoiceExtended.InternalRecursiveSave();
}


public RC_2c7478516bbd3eed6a35183496a9f500 Duplicate() {
RC_2c7478516bbd3eed6a35183496a9f500 t;
t.ssENInvoice = (EN_d1d0320db36efbb094ad0082361435a0EntityRecord)this.ssENInvoice.Duplicate();
t.ssENInvoiceExtendedReceiver = (EN_b0c20b1f1237d3e4f4e5e432cd60cb6aEntityRecord)this.ssENInvoiceExtendedReceiver.Duplicate();
t.ssENInvoiceExtendedCartaPorte = (EN_9bd576a05df3846c52ce88a606aff414EntityRecord)this.ssENInvoiceExtendedCartaPorte.Duplicate();
t.ssENInvoiceExtendedIssuer = (EN_1ca446167f1a5fee035306f622895668EntityRecord)this.ssENInvoiceExtendedIssuer.Duplicate();
t.ssENInvoiceAccounting = (EN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord)this.ssENInvoiceAccounting.Duplicate();
t.ssENInvoiceExtended = (EN_f81a3d226103fd013068b8763798067aEntityRecord)this.ssENInvoiceExtended.Duplicate();
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
} else if (head == "invoiceextendedreceiver") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceExtendedReceiver")) variable.Value = ssENInvoiceExtendedReceiver; else variable.Optimized = true;
variable.SetFieldName("invoiceextendedreceiver");
} else if (head == "invoiceextendedcartaporte") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceExtendedCartaPorte")) variable.Value = ssENInvoiceExtendedCartaPorte; else variable.Optimized = true;
variable.SetFieldName("invoiceextendedcartaporte");
} else if (head == "invoiceextendedissuer") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceExtendedIssuer")) variable.Value = ssENInvoiceExtendedIssuer; else variable.Optimized = true;
variable.SetFieldName("invoiceextendedissuer");
} else if (head == "invoiceaccounting") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceAccounting")) variable.Value = ssENInvoiceAccounting; else variable.Optimized = true;
variable.SetFieldName("invoiceaccounting");
} else if (head == "invoiceextended") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceExtended")) variable.Value = ssENInvoiceExtended; else variable.Optimized = true;
variable.SetFieldName("invoiceextended");
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
if (key == IdInvoiceExtendedReceiver) {
return ssENInvoiceExtendedReceiver;
}
if (key == IdInvoiceExtendedCartaPorte) {
return ssENInvoiceExtendedCartaPorte;
}
if (key == IdInvoiceExtendedIssuer) {
return ssENInvoiceExtendedIssuer;
}
if (key == IdInvoiceAccounting) {
return ssENInvoiceAccounting;
}
if (key == IdInvoiceExtended) {
return ssENInvoiceExtended;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInvoice.Key.AsGuid) {
return ssENInvoice;
}
if (attributeKey == IdInvoiceExtendedReceiver.Key.AsGuid) {
return ssENInvoiceExtendedReceiver;
}
if (attributeKey == IdInvoiceExtendedCartaPorte.Key.AsGuid) {
return ssENInvoiceExtendedCartaPorte;
}
if (attributeKey == IdInvoiceExtendedIssuer.Key.AsGuid) {
return ssENInvoiceExtendedIssuer;
}
if (attributeKey == IdInvoiceAccounting.Key.AsGuid) {
return ssENInvoiceAccounting;
}
if (attributeKey == IdInvoiceExtended.Key.AsGuid) {
return ssENInvoiceExtended;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENInvoice.FillFromOther((IRecord) other.AttributeGet(IdInvoice));
ssENInvoiceExtendedReceiver.FillFromOther((IRecord) other.AttributeGet(IdInvoiceExtendedReceiver));
ssENInvoiceExtendedCartaPorte.FillFromOther((IRecord) other.AttributeGet(IdInvoiceExtendedCartaPorte));
ssENInvoiceExtendedIssuer.FillFromOther((IRecord) other.AttributeGet(IdInvoiceExtendedIssuer));
ssENInvoiceAccounting.FillFromOther((IRecord) other.AttributeGet(IdInvoiceAccounting));
ssENInvoiceExtended.FillFromOther((IRecord) other.AttributeGet(IdInvoiceExtended));
}
} // RC_2c7478516bbd3eed6a35183496a9f500
/// <summary>
/// RecordList type
///  <code>InvoiceInvoiceExtendedReceiverInvoiceExtendedCartaPorteInvoiceExtendedIssuerInvoiceAccounting
/// InvoiceExtendedRecordList</code> that represents a record list of <code>Invoice,
///  InvoiceExtendedReceiver, InvoiceExtendedCartaPorte, InvoiceExtendedIssuer, InvoiceAccounting
/// , InvoiceExtended</code>
/// </summary>
public partial class RL_ec81b8a47286cf2b9fe9bbf727e9ade3 : GenericRecordList<RC_2c7478516bbd3eed6a35183496a9f500>, IEnumerable, IEnumerator {

protected override RC_2c7478516bbd3eed6a35183496a9f500 GetElementDefaultValue() {
return new RC_2c7478516bbd3eed6a35183496a9f500();
}

public T[] ToArray<T>(Func<RC_2c7478516bbd3eed6a35183496a9f500, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_ec81b8a47286cf2b9fe9bbf727e9ade3 recordList, Func<RC_2c7478516bbd3eed6a35183496a9f500, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_ec81b8a47286cf2b9fe9bbf727e9ade3(RC_2c7478516bbd3eed6a35183496a9f500[] array) {
  RL_ec81b8a47286cf2b9fe9bbf727e9ade3 result = new RL_ec81b8a47286cf2b9fe9bbf727e9ade3();
result.InnerFromArray(array);
    return result;
}

public static RL_ec81b8a47286cf2b9fe9bbf727e9ade3 ToList<T>(T[] array, Func <T, RC_2c7478516bbd3eed6a35183496a9f500> converter) {
  RL_ec81b8a47286cf2b9fe9bbf727e9ade3 result = new RL_ec81b8a47286cf2b9fe9bbf727e9ade3();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_ec81b8a47286cf2b9fe9bbf727e9ade3 FromRestList<T>(RestList<T> restList, Func <T, RC_2c7478516bbd3eed6a35183496a9f500> converter) {
  RL_ec81b8a47286cf2b9fe9bbf727e9ade3 result = new RL_ec81b8a47286cf2b9fe9bbf727e9ade3();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_ec81b8a47286cf2b9fe9bbf727e9ade3() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[6];
def[0] = new BitArray(24,false);
def[1] = new BitArray(5,false);
def[2] = new BitArray(7,false);
def[3] = new BitArray(5,false);
def[4] = new BitArray(21,false);
def[5] = new BitArray(19,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_2c7478516bbd3eed6a35183496a9f500> NewList() {
return new RL_ec81b8a47286cf2b9fe9bbf727e9ade3();
}


} // RL_ec81b8a47286cf2b9fe9bbf727e9ade3
}

