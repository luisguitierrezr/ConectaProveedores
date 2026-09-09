namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (LLkEuJfrDEeuRb_bISjhoQ)
///  <code>RC_3f6ba4c81bcd03d8108335ecd7631ff4</code> that represent
/// s <code>SupplierUserSupplierRegionRecord</code> <p>Description: </p>
/// </summary>
// Name: SupplierUserSupplierRegionRecord
public partial struct RC_3f6ba4c81bcd03d8108335ecd7631ff4 : ITypedRecord<RC_3f6ba4c81bcd03d8108335ecd7631ff4> {
internal static readonly GlobalObjectKey IdSupplierUser = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*7OnmMx8g4GXre9XSUReN7w");
internal static readonly GlobalObjectKey IdSupplier = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*dOw0SWrcY4B7hMCYX1sSzg");
internal static readonly GlobalObjectKey IdRegion = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*w1243kBmkvqNrl3ySTBl0A");

public EN_360367a38fba8439556dd1e5826e0428EntityRecord ssENSupplierUser;

public EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord ssENSupplier;

public EN_31f501c551d210017fcb34b5237e3390EntityRecord ssENRegion;


public BitArray OptimizedAttributes;

public RC_3f6ba4c81bcd03d8108335ecd7631ff4() {
OptimizedAttributes = null;
ssENSupplierUser = new EN_360367a38fba8439556dd1e5826e0428EntityRecord();
ssENSupplier = new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord();
ssENRegion = new EN_31f501c551d210017fcb34b5237e3390EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[3];
    all[0] = new BitArray(15,false);
    all[1] = new BitArray(28,false);
    all[2] = new BitArray(13,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENSupplierUser.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENSupplier.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENRegion.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    }else{
    ssENSupplierUser.OptimizedAttributes = value[0];
    ssENSupplier.OptimizedAttributes = value[1];
    ssENRegion.OptimizedAttributes = value[2];
    }
}
get{
    BitArray[] all = new BitArray[3];
    all[0] = ssENSupplierUser.OptimizedAttributes;
    all[1] = ssENSupplier.OptimizedAttributes;
    all[2] = ssENRegion.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENSupplierUser.Read( r, ref index);
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
public void ReadIM(RC_3f6ba4c81bcd03d8108335ecd7631ff4 r) {
this = r;
}


public static bool operator == (RC_3f6ba4c81bcd03d8108335ecd7631ff4 a, RC_3f6ba4c81bcd03d8108335ecd7631ff4 b) {
if (a.ssENSupplierUser != b.ssENSupplierUser) return false;
if (a.ssENSupplier != b.ssENSupplier) return false;
if (a.ssENRegion != b.ssENRegion) return false;
return true;
}

public static bool operator != (RC_3f6ba4c81bcd03d8108335ecd7631ff4 a, RC_3f6ba4c81bcd03d8108335ecd7631ff4 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_3f6ba4c81bcd03d8108335ecd7631ff4)) return false;
return (this == (RC_3f6ba4c81bcd03d8108335ecd7631ff4)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENSupplierUser.GetHashCode()
 ^ ssENSupplier.GetHashCode()
 ^ ssENRegion.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENSupplierUser.RecursiveReset();
ssENSupplier.RecursiveReset();
ssENRegion.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENSupplierUser.InternalRecursiveSave();
ssENSupplier.InternalRecursiveSave();
ssENRegion.InternalRecursiveSave();
}


public RC_3f6ba4c81bcd03d8108335ecd7631ff4 Duplicate() {
RC_3f6ba4c81bcd03d8108335ecd7631ff4 t;
t.ssENSupplierUser = (EN_360367a38fba8439556dd1e5826e0428EntityRecord)this.ssENSupplierUser.Duplicate();
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
if (head == "supplieruser") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SupplierUser")) variable.Value = ssENSupplierUser; else variable.Optimized = true;
variable.SetFieldName("supplieruser");
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
if (key == IdSupplierUser) {
return ssENSupplierUser;
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
if (attributeKey == IdSupplierUser.Key.AsGuid) {
return ssENSupplierUser;
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
ssENSupplierUser.FillFromOther((IRecord) other.AttributeGet(IdSupplierUser));
ssENSupplier.FillFromOther((IRecord) other.AttributeGet(IdSupplier));
ssENRegion.FillFromOther((IRecord) other.AttributeGet(IdRegion));
}
} // RC_3f6ba4c81bcd03d8108335ecd7631ff4
/// <summary>
/// RecordList type <code>SupplierUserSupplierRegionRecordList</code> that represents a record list of
///  <code>SupplierUser, Supplier, Region</code>
/// </summary>
public partial class RL_5859a4306a0de95c2b5c534d5cfa7150 : GenericRecordList<RC_3f6ba4c81bcd03d8108335ecd7631ff4>, IEnumerable, IEnumerator {

protected override RC_3f6ba4c81bcd03d8108335ecd7631ff4 GetElementDefaultValue() {
return new RC_3f6ba4c81bcd03d8108335ecd7631ff4();
}

public T[] ToArray<T>(Func<RC_3f6ba4c81bcd03d8108335ecd7631ff4, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_5859a4306a0de95c2b5c534d5cfa7150 recordList, Func<RC_3f6ba4c81bcd03d8108335ecd7631ff4, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_5859a4306a0de95c2b5c534d5cfa7150(RC_3f6ba4c81bcd03d8108335ecd7631ff4[] array) {
  RL_5859a4306a0de95c2b5c534d5cfa7150 result = new RL_5859a4306a0de95c2b5c534d5cfa7150();
result.InnerFromArray(array);
    return result;
}

public static RL_5859a4306a0de95c2b5c534d5cfa7150 ToList<T>(T[] array, Func <T, RC_3f6ba4c81bcd03d8108335ecd7631ff4> converter) {
  RL_5859a4306a0de95c2b5c534d5cfa7150 result = new RL_5859a4306a0de95c2b5c534d5cfa7150();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_5859a4306a0de95c2b5c534d5cfa7150 FromRestList<T>(RestList<T> restList, Func <T, RC_3f6ba4c81bcd03d8108335ecd7631ff4> converter) {
  RL_5859a4306a0de95c2b5c534d5cfa7150 result = new RL_5859a4306a0de95c2b5c534d5cfa7150();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_5859a4306a0de95c2b5c534d5cfa7150() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[3];
def[0] = new BitArray(15,false);
def[1] = new BitArray(28,false);
def[2] = new BitArray(13,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_3f6ba4c81bcd03d8108335ecd7631ff4> NewList() {
return new RL_5859a4306a0de95c2b5c534d5cfa7150();
}


} // RL_5859a4306a0de95c2b5c534d5cfa7150
}

