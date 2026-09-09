namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (P1JcABrp4UOoiiiDQImSNw)
///  <code>RC_e2b9f65e0c0c00d0e673b5a8e6e47435</code> that represent
/// s <code>FolioStatusInvoiceFolioFolioExtendedOrderMainSupplierRegionRecord</code> <p>Description:
///  </p>
/// </summary>
// Name: FolioStatusInvoiceFolioFolioExtendedOrderMainSupplierRegionRecord
public partial struct RC_e2b9f65e0c0c00d0e673b5a8e6e47435 : ITypedRecord<RC_e2b9f65e0c0c00d0e673b5a8e6e47435> {
internal static readonly GlobalObjectKey IdFolioStatus = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*svddx8bnSuc6Rd2nvXuT4g");
internal static readonly GlobalObjectKey IdInvoice = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*a5jFBMcyL4IDPJM89xuWvQ");
internal static readonly GlobalObjectKey IdFolio = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*+Czrz7YK54PZqbXQLZyVJg");
internal static readonly GlobalObjectKey IdFolioExtended = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*wrKSrSIXsY0Mcbr5CmFepQ");
internal static readonly GlobalObjectKey IdOrderMain = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*SNWDFQxCHyP7k0WDEoAERg");
internal static readonly GlobalObjectKey IdSupplier = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*dOw0SWrcY4B7hMCYX1sSzg");
internal static readonly GlobalObjectKey IdRegion = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*w1243kBmkvqNrl3ySTBl0A");

public EN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord ssENFolioStatus;

public EN_d1d0320db36efbb094ad0082361435a0EntityRecord ssENInvoice;

public EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord ssENFolio;

public EN_a068be6d15bdd7253c79d3c9b7f78f6bEntityRecord ssENFolioExtended;

public EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord ssENOrderMain;

public EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord ssENSupplier;

public EN_31f501c551d210017fcb34b5237e3390EntityRecord ssENRegion;


public BitArray OptimizedAttributes;

public RC_e2b9f65e0c0c00d0e673b5a8e6e47435() {
OptimizedAttributes = null;
ssENFolioStatus = new EN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord();
ssENInvoice = new EN_d1d0320db36efbb094ad0082361435a0EntityRecord();
ssENFolio = new EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord();
ssENFolioExtended = new EN_a068be6d15bdd7253c79d3c9b7f78f6bEntityRecord();
ssENOrderMain = new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord();
ssENSupplier = new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord();
ssENRegion = new EN_31f501c551d210017fcb34b5237e3390EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[7];
    all[0] = new BitArray(6,false);
    all[1] = new BitArray(24,false);
    all[2] = new BitArray(20,false);
    all[3] = new BitArray(8,false);
    all[4] = new BitArray(29,false);
    all[5] = new BitArray(28,false);
    all[6] = new BitArray(13,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENFolioStatus.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENInvoice.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENFolio.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENFolioExtended.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    ssENOrderMain.OptimizedAttributes = GetDefaultOptimizedValues()[4];
    ssENSupplier.OptimizedAttributes = GetDefaultOptimizedValues()[5];
    ssENRegion.OptimizedAttributes = GetDefaultOptimizedValues()[6];
    }else{
    ssENFolioStatus.OptimizedAttributes = value[0];
    ssENInvoice.OptimizedAttributes = value[1];
    ssENFolio.OptimizedAttributes = value[2];
    ssENFolioExtended.OptimizedAttributes = value[3];
    ssENOrderMain.OptimizedAttributes = value[4];
    ssENSupplier.OptimizedAttributes = value[5];
    ssENRegion.OptimizedAttributes = value[6];
    }
}
get{
    BitArray[] all = new BitArray[7];
    all[0] = ssENFolioStatus.OptimizedAttributes;
    all[1] = ssENInvoice.OptimizedAttributes;
    all[2] = ssENFolio.OptimizedAttributes;
    all[3] = ssENFolioExtended.OptimizedAttributes;
    all[4] = ssENOrderMain.OptimizedAttributes;
    all[5] = ssENSupplier.OptimizedAttributes;
    all[6] = ssENRegion.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENFolioStatus.Read( r, ref index);
ssENInvoice.Read( r, ref index);
ssENFolio.Read( r, ref index);
ssENFolioExtended.Read( r, ref index);
ssENOrderMain.Read( r, ref index);
ssENSupplier.Read( r, ref index);
ssENRegion.Read( r, ref index);
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
public void ReadIM(RC_e2b9f65e0c0c00d0e673b5a8e6e47435 r) {
this = r;
}


public static bool operator == (RC_e2b9f65e0c0c00d0e673b5a8e6e47435 a, RC_e2b9f65e0c0c00d0e673b5a8e6e47435 b) {
if (a.ssENFolioStatus != b.ssENFolioStatus) return false;
if (a.ssENInvoice != b.ssENInvoice) return false;
if (a.ssENFolio != b.ssENFolio) return false;
if (a.ssENFolioExtended != b.ssENFolioExtended) return false;
if (a.ssENOrderMain != b.ssENOrderMain) return false;
if (a.ssENSupplier != b.ssENSupplier) return false;
if (a.ssENRegion != b.ssENRegion) return false;
return true;
}

public static bool operator != (RC_e2b9f65e0c0c00d0e673b5a8e6e47435 a, RC_e2b9f65e0c0c00d0e673b5a8e6e47435 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_e2b9f65e0c0c00d0e673b5a8e6e47435)) return false;
return (this == (RC_e2b9f65e0c0c00d0e673b5a8e6e47435)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENFolioStatus.GetHashCode()
 ^ ssENInvoice.GetHashCode()
 ^ ssENFolio.GetHashCode()
 ^ ssENFolioExtended.GetHashCode()
 ^ ssENOrderMain.GetHashCode()
 ^ ssENSupplier.GetHashCode()
 ^ ssENRegion.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENFolioStatus.RecursiveReset();
ssENInvoice.RecursiveReset();
ssENFolio.RecursiveReset();
ssENFolioExtended.RecursiveReset();
ssENOrderMain.RecursiveReset();
ssENSupplier.RecursiveReset();
ssENRegion.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENFolioStatus.InternalRecursiveSave();
ssENInvoice.InternalRecursiveSave();
ssENFolio.InternalRecursiveSave();
ssENFolioExtended.InternalRecursiveSave();
ssENOrderMain.InternalRecursiveSave();
ssENSupplier.InternalRecursiveSave();
ssENRegion.InternalRecursiveSave();
}


public RC_e2b9f65e0c0c00d0e673b5a8e6e47435 Duplicate() {
RC_e2b9f65e0c0c00d0e673b5a8e6e47435 t;
t.ssENFolioStatus = (EN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord)this.ssENFolioStatus.Duplicate();
t.ssENInvoice = (EN_d1d0320db36efbb094ad0082361435a0EntityRecord)this.ssENInvoice.Duplicate();
t.ssENFolio = (EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord)this.ssENFolio.Duplicate();
t.ssENFolioExtended = (EN_a068be6d15bdd7253c79d3c9b7f78f6bEntityRecord)this.ssENFolioExtended.Duplicate();
t.ssENOrderMain = (EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord)this.ssENOrderMain.Duplicate();
t.ssENSupplier = (EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord)this.ssENSupplier.Duplicate();
t.ssENRegion = (EN_31f501c551d210017fcb34b5237e3390EntityRecord)this.ssENRegion.Duplicate();
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
if (head == "foliostatus") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FolioStatus")) variable.Value = ssENFolioStatus; else variable.Optimized = true;
variable.SetFieldName("foliostatus");
} else if (head == "invoice") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Invoice")) variable.Value = ssENInvoice; else variable.Optimized = true;
variable.SetFieldName("invoice");
} else if (head == "folio") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Folio")) variable.Value = ssENFolio; else variable.Optimized = true;
variable.SetFieldName("folio");
} else if (head == "folioextended") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FolioExtended")) variable.Value = ssENFolioExtended; else variable.Optimized = true;
variable.SetFieldName("folioextended");
} else if (head == "ordermain") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderMain")) variable.Value = ssENOrderMain; else variable.Optimized = true;
variable.SetFieldName("ordermain");
} else if (head == "supplier") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Supplier")) variable.Value = ssENSupplier; else variable.Optimized = true;
variable.SetFieldName("supplier");
} else if (head == "region") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Region")) variable.Value = ssENRegion; else variable.Optimized = true;
variable.SetFieldName("region");
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
if (key == IdFolioStatus) {
return ssENFolioStatus;
}
if (key == IdInvoice) {
return ssENInvoice;
}
if (key == IdFolio) {
return ssENFolio;
}
if (key == IdFolioExtended) {
return ssENFolioExtended;
}
if (key == IdOrderMain) {
return ssENOrderMain;
}
if (key == IdSupplier) {
return ssENSupplier;
}
if (key == IdRegion) {
return ssENRegion;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdFolioStatus.Key.AsGuid) {
return ssENFolioStatus;
}
if (attributeKey == IdInvoice.Key.AsGuid) {
return ssENInvoice;
}
if (attributeKey == IdFolio.Key.AsGuid) {
return ssENFolio;
}
if (attributeKey == IdFolioExtended.Key.AsGuid) {
return ssENFolioExtended;
}
if (attributeKey == IdOrderMain.Key.AsGuid) {
return ssENOrderMain;
}
if (attributeKey == IdSupplier.Key.AsGuid) {
return ssENSupplier;
}
if (attributeKey == IdRegion.Key.AsGuid) {
return ssENRegion;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENFolioStatus.FillFromOther((IRecord) other.AttributeGet(IdFolioStatus));
ssENInvoice.FillFromOther((IRecord) other.AttributeGet(IdInvoice));
ssENFolio.FillFromOther((IRecord) other.AttributeGet(IdFolio));
ssENFolioExtended.FillFromOther((IRecord) other.AttributeGet(IdFolioExtended));
ssENOrderMain.FillFromOther((IRecord) other.AttributeGet(IdOrderMain));
ssENSupplier.FillFromOther((IRecord) other.AttributeGet(IdSupplier));
ssENRegion.FillFromOther((IRecord) other.AttributeGet(IdRegion));
}
} // RC_e2b9f65e0c0c00d0e673b5a8e6e47435
/// <summary>
/// RecordList type <code>FolioStatusInvoiceFolioFolioExtendedOrderMainSupplierRegionRecordList</code>
///  that represents a record list of <code>FolioStatus, Invoice, Folio, FolioExtended, OrderMain
/// , Supplier, Region</code>
/// </summary>
public partial class RL_e9c01eb22ad9114f17ae2b674328008c : GenericRecordList<RC_e2b9f65e0c0c00d0e673b5a8e6e47435>, IEnumerable, IEnumerator {

protected override RC_e2b9f65e0c0c00d0e673b5a8e6e47435 GetElementDefaultValue() {
return new RC_e2b9f65e0c0c00d0e673b5a8e6e47435();
}

public T[] ToArray<T>(Func<RC_e2b9f65e0c0c00d0e673b5a8e6e47435, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_e9c01eb22ad9114f17ae2b674328008c recordList, Func<RC_e2b9f65e0c0c00d0e673b5a8e6e47435, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_e9c01eb22ad9114f17ae2b674328008c(RC_e2b9f65e0c0c00d0e673b5a8e6e47435[] array) {
  RL_e9c01eb22ad9114f17ae2b674328008c result = new RL_e9c01eb22ad9114f17ae2b674328008c();
result.InnerFromArray(array);
    return result;
}

public static RL_e9c01eb22ad9114f17ae2b674328008c ToList<T>(T[] array, Func <T, RC_e2b9f65e0c0c00d0e673b5a8e6e47435> converter) {
  RL_e9c01eb22ad9114f17ae2b674328008c result = new RL_e9c01eb22ad9114f17ae2b674328008c();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_e9c01eb22ad9114f17ae2b674328008c FromRestList<T>(RestList<T> restList, Func <T, RC_e2b9f65e0c0c00d0e673b5a8e6e47435> converter) {
  RL_e9c01eb22ad9114f17ae2b674328008c result = new RL_e9c01eb22ad9114f17ae2b674328008c();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_e9c01eb22ad9114f17ae2b674328008c() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[7];
def[0] = new BitArray(6,false);
def[1] = new BitArray(24,false);
def[2] = new BitArray(20,false);
def[3] = new BitArray(8,false);
def[4] = new BitArray(29,false);
def[5] = new BitArray(28,false);
def[6] = new BitArray(13,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_e2b9f65e0c0c00d0e673b5a8e6e47435> NewList() {
return new RL_e9c01eb22ad9114f17ae2b674328008c();
}


} // RL_e9c01eb22ad9114f17ae2b674328008c
}

