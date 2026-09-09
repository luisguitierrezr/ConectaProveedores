namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (6vcnCqnthUSDfNm2W23x0A)
///  <code>RC_f520669a02d9f27d638b5ecc83782607</code> that represent
/// s <code>FolioStatusFolioOrderMainSupplierRecord</code> <p>Description: </p>
/// </summary>
// Name: FolioStatusFolioOrderMainSupplierRecord
public partial struct RC_f520669a02d9f27d638b5ecc83782607 : ITypedRecord<RC_f520669a02d9f27d638b5ecc83782607> {
internal static readonly GlobalObjectKey IdFolioStatus = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*svddx8bnSuc6Rd2nvXuT4g");
internal static readonly GlobalObjectKey IdFolio = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*+Czrz7YK54PZqbXQLZyVJg");
internal static readonly GlobalObjectKey IdOrderMain = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*SNWDFQxCHyP7k0WDEoAERg");
internal static readonly GlobalObjectKey IdSupplier = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*dOw0SWrcY4B7hMCYX1sSzg");

public EN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord ssENFolioStatus;

public EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord ssENFolio;

public EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord ssENOrderMain;

public EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord ssENSupplier;


public BitArray OptimizedAttributes;

public RC_f520669a02d9f27d638b5ecc83782607() {
OptimizedAttributes = null;
ssENFolioStatus = new EN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord();
ssENFolio = new EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord();
ssENOrderMain = new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord();
ssENSupplier = new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[4];
    all[0] = new BitArray(6,false);
    all[1] = new BitArray(20,false);
    all[2] = new BitArray(29,false);
    all[3] = new BitArray(28,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENFolioStatus.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENFolio.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENOrderMain.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENSupplier.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    }else{
    ssENFolioStatus.OptimizedAttributes = value[0];
    ssENFolio.OptimizedAttributes = value[1];
    ssENOrderMain.OptimizedAttributes = value[2];
    ssENSupplier.OptimizedAttributes = value[3];
    }
}
get{
    BitArray[] all = new BitArray[4];
    all[0] = ssENFolioStatus.OptimizedAttributes;
    all[1] = ssENFolio.OptimizedAttributes;
    all[2] = ssENOrderMain.OptimizedAttributes;
    all[3] = ssENSupplier.OptimizedAttributes;
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
ssENFolio.Read( r, ref index);
ssENOrderMain.Read( r, ref index);
ssENSupplier.Read( r, ref index);
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
public void ReadIM(RC_f520669a02d9f27d638b5ecc83782607 r) {
this = r;
}


public static bool operator == (RC_f520669a02d9f27d638b5ecc83782607 a, RC_f520669a02d9f27d638b5ecc83782607 b) {
if (a.ssENFolioStatus != b.ssENFolioStatus) return false;
if (a.ssENFolio != b.ssENFolio) return false;
if (a.ssENOrderMain != b.ssENOrderMain) return false;
if (a.ssENSupplier != b.ssENSupplier) return false;
return true;
}

public static bool operator != (RC_f520669a02d9f27d638b5ecc83782607 a, RC_f520669a02d9f27d638b5ecc83782607 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_f520669a02d9f27d638b5ecc83782607)) return false;
return (this == (RC_f520669a02d9f27d638b5ecc83782607)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENFolioStatus.GetHashCode()
 ^ ssENFolio.GetHashCode()
 ^ ssENOrderMain.GetHashCode()
 ^ ssENSupplier.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENFolioStatus.RecursiveReset();
ssENFolio.RecursiveReset();
ssENOrderMain.RecursiveReset();
ssENSupplier.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENFolioStatus.InternalRecursiveSave();
ssENFolio.InternalRecursiveSave();
ssENOrderMain.InternalRecursiveSave();
ssENSupplier.InternalRecursiveSave();
}


public RC_f520669a02d9f27d638b5ecc83782607 Duplicate() {
RC_f520669a02d9f27d638b5ecc83782607 t;
t.ssENFolioStatus = (EN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord)this.ssENFolioStatus.Duplicate();
t.ssENFolio = (EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord)this.ssENFolio.Duplicate();
t.ssENOrderMain = (EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord)this.ssENOrderMain.Duplicate();
t.ssENSupplier = (EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord)this.ssENSupplier.Duplicate();
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
} else if (head == "folio") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Folio")) variable.Value = ssENFolio; else variable.Optimized = true;
variable.SetFieldName("folio");
} else if (head == "ordermain") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderMain")) variable.Value = ssENOrderMain; else variable.Optimized = true;
variable.SetFieldName("ordermain");
} else if (head == "supplier") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Supplier")) variable.Value = ssENSupplier; else variable.Optimized = true;
variable.SetFieldName("supplier");
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
if (key == IdFolio) {
return ssENFolio;
}
if (key == IdOrderMain) {
return ssENOrderMain;
}
if (key == IdSupplier) {
return ssENSupplier;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdFolioStatus.Key.AsGuid) {
return ssENFolioStatus;
}
if (attributeKey == IdFolio.Key.AsGuid) {
return ssENFolio;
}
if (attributeKey == IdOrderMain.Key.AsGuid) {
return ssENOrderMain;
}
if (attributeKey == IdSupplier.Key.AsGuid) {
return ssENSupplier;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENFolioStatus.FillFromOther((IRecord) other.AttributeGet(IdFolioStatus));
ssENFolio.FillFromOther((IRecord) other.AttributeGet(IdFolio));
ssENOrderMain.FillFromOther((IRecord) other.AttributeGet(IdOrderMain));
ssENSupplier.FillFromOther((IRecord) other.AttributeGet(IdSupplier));
}
} // RC_f520669a02d9f27d638b5ecc83782607
/// <summary>
/// RecordList type <code>FolioStatusFolioOrderMainSupplierRecordList</code> that represents a record
///  list of <code>FolioStatus, Folio, OrderMain, Supplier</code>
/// </summary>
public partial class RL_cb63d2f3bb3714fa686ba5a50757aacf : GenericRecordList<RC_f520669a02d9f27d638b5ecc83782607>, IEnumerable, IEnumerator {

protected override RC_f520669a02d9f27d638b5ecc83782607 GetElementDefaultValue() {
return new RC_f520669a02d9f27d638b5ecc83782607();
}

public T[] ToArray<T>(Func<RC_f520669a02d9f27d638b5ecc83782607, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_cb63d2f3bb3714fa686ba5a50757aacf recordList, Func<RC_f520669a02d9f27d638b5ecc83782607, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_cb63d2f3bb3714fa686ba5a50757aacf(RC_f520669a02d9f27d638b5ecc83782607[] array) {
  RL_cb63d2f3bb3714fa686ba5a50757aacf result = new RL_cb63d2f3bb3714fa686ba5a50757aacf();
result.InnerFromArray(array);
    return result;
}

public static RL_cb63d2f3bb3714fa686ba5a50757aacf ToList<T>(T[] array, Func <T, RC_f520669a02d9f27d638b5ecc83782607> converter) {
  RL_cb63d2f3bb3714fa686ba5a50757aacf result = new RL_cb63d2f3bb3714fa686ba5a50757aacf();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_cb63d2f3bb3714fa686ba5a50757aacf FromRestList<T>(RestList<T> restList, Func <T, RC_f520669a02d9f27d638b5ecc83782607> converter) {
  RL_cb63d2f3bb3714fa686ba5a50757aacf result = new RL_cb63d2f3bb3714fa686ba5a50757aacf();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_cb63d2f3bb3714fa686ba5a50757aacf() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[4];
def[0] = new BitArray(6,false);
def[1] = new BitArray(20,false);
def[2] = new BitArray(29,false);
def[3] = new BitArray(28,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_f520669a02d9f27d638b5ecc83782607> NewList() {
return new RL_cb63d2f3bb3714fa686ba5a50757aacf();
}


} // RL_cb63d2f3bb3714fa686ba5a50757aacf
}

