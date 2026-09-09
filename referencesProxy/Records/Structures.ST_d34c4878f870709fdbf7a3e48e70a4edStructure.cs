namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [ReferenceStructure] PI_ITEM (Y1OaoAv2xkOjv0Hdz9HOjA)
///  <code>ST_d34c4878f870709fdbf7a3e48e70a4edStructure</code> that represents <code>PI_ITEM</code
/// > <p>Description: </p>
/// </summary>
// Name: PI_ITEM
public partial struct ST_d34c4878f870709fdbf7a3e48e70a4edStructure : ITypedRecord<ST_d34c4878f870709fdbf7a3e48e70a4edStructure> {
internal static readonly GlobalObjectKey IdPOSICION_PEDIDO = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*ZLlEkIO8n0mPeVJWL9v10g");
internal static readonly GlobalObjectKey IdMATERIAL = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*SIkVA+rZYEeNx0YCcJQNOA");
internal static readonly GlobalObjectKey IdCENTRO = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*zoUpBkXP6k27nnmIzsX9ew");
internal static readonly GlobalObjectKey IdALMACEN = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*sx+GBh7hzkiTI6TsvRG_uQ");
internal static readonly GlobalObjectKey IdCANTIDAD_ENTRADA = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*+PIlMHA2OkiXb6aab8NUhg");
internal static readonly GlobalObjectKey IdTEXTO_POSICION = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*UAA_Cl_C8E6YJ5xRnyXvHA");

public int ssPOSICION_PEDIDO;

public string ssMATERIAL;

public string ssCENTRO;

public string ssALMACEN;

public decimal ssCANTIDAD_ENTRADA;

public string ssTEXTO_POSICION;


public BitArray OptimizedAttributes;

public ST_d34c4878f870709fdbf7a3e48e70a4edStructure() {
OptimizedAttributes = null;
ssPOSICION_PEDIDO = -2147483648;
ssMATERIAL = "";
ssCENTRO = "";
ssALMACEN = "";
ssCANTIDAD_ENTRADA = -79228162514264337593543950335m;
ssTEXTO_POSICION = "";
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[0];
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    }
}
get{
    BitArray[] all = new BitArray[0];
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssPOSICION_PEDIDO = r.ReadInteger(index++, "PI_ITEM.POSICION_PEDIDO", 0);
ssMATERIAL = r.ReadText(index++, "PI_ITEM.MATERIAL", "");
ssCENTRO = r.ReadText(index++, "PI_ITEM.CENTRO", "");
ssALMACEN = r.ReadText(index++, "PI_ITEM.ALMACEN", "");
ssCANTIDAD_ENTRADA = r.ReadDecimal(index++, "PI_ITEM.CANTIDAD_ENTRADA", 0.0M);
ssTEXTO_POSICION = r.ReadText(index++, "PI_ITEM.TEXTO_POSICION", "");
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
public void ReadIM(ST_d34c4878f870709fdbf7a3e48e70a4edStructure r) {
this = r;
}


public static bool operator == (ST_d34c4878f870709fdbf7a3e48e70a4edStructure a, ST_d34c4878f870709fdbf7a3e48e70a4edStructure b) {
if (a.ssPOSICION_PEDIDO != b.ssPOSICION_PEDIDO) return false;
if (a.ssMATERIAL != b.ssMATERIAL) return false;
if (a.ssCENTRO != b.ssCENTRO) return false;
if (a.ssALMACEN != b.ssALMACEN) return false;
if (a.ssCANTIDAD_ENTRADA != b.ssCANTIDAD_ENTRADA) return false;
if (a.ssTEXTO_POSICION != b.ssTEXTO_POSICION) return false;
return true;
}

public static bool operator != (ST_d34c4878f870709fdbf7a3e48e70a4edStructure a, ST_d34c4878f870709fdbf7a3e48e70a4edStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_d34c4878f870709fdbf7a3e48e70a4edStructure)) return false;
return (this == (ST_d34c4878f870709fdbf7a3e48e70a4edStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssPOSICION_PEDIDO.GetHashCode()
 ^ ssMATERIAL.GetHashCode()
 ^ ssCENTRO.GetHashCode()
 ^ ssALMACEN.GetHashCode()
 ^ ssCANTIDAD_ENTRADA.GetHashCode()
 ^ ssTEXTO_POSICION.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_d34c4878f870709fdbf7a3e48e70a4edStructure Duplicate() {
ST_d34c4878f870709fdbf7a3e48e70a4edStructure t;
t.ssPOSICION_PEDIDO = this.ssPOSICION_PEDIDO;
t.ssMATERIAL = this.ssMATERIAL;
t.ssCENTRO = this.ssCENTRO;
t.ssALMACEN = this.ssALMACEN;
t.ssCANTIDAD_ENTRADA = this.ssCANTIDAD_ENTRADA;
t.ssTEXTO_POSICION = this.ssTEXTO_POSICION;
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
if (head == "posicion_pedido") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".POSICION_PEDIDO")) variable.Value = ssPOSICION_PEDIDO; else variable.Optimized = true;
} else if (head == "material") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".MATERIAL")) variable.Value = ssMATERIAL; else variable.Optimized = true;
} else if (head == "centro") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CENTRO")) variable.Value = ssCENTRO; else variable.Optimized = true;
} else if (head == "almacen") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ALMACEN")) variable.Value = ssALMACEN; else variable.Optimized = true;
} else if (head == "cantidad_entrada") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CANTIDAD_ENTRADA")) variable.Value = ssCANTIDAD_ENTRADA; else variable.Optimized = true;
} else if (head == "texto_posicion") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TEXTO_POSICION")) variable.Value = ssTEXTO_POSICION; else variable.Optimized = true;
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
if (key == IdPOSICION_PEDIDO) {
return ssPOSICION_PEDIDO;
}
if (key == IdMATERIAL) {
return ssMATERIAL;
}
if (key == IdCENTRO) {
return ssCENTRO;
}
if (key == IdALMACEN) {
return ssALMACEN;
}
if (key == IdCANTIDAD_ENTRADA) {
return ssCANTIDAD_ENTRADA;
}
if (key == IdTEXTO_POSICION) {
return ssTEXTO_POSICION;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdPOSICION_PEDIDO.Key.AsGuid) {
return ssPOSICION_PEDIDO;
}
if (attributeKey == IdMATERIAL.Key.AsGuid) {
return ssMATERIAL;
}
if (attributeKey == IdCENTRO.Key.AsGuid) {
return ssCENTRO;
}
if (attributeKey == IdALMACEN.Key.AsGuid) {
return ssALMACEN;
}
if (attributeKey == IdCANTIDAD_ENTRADA.Key.AsGuid) {
return ssCANTIDAD_ENTRADA;
}
if (attributeKey == IdTEXTO_POSICION.Key.AsGuid) {
return ssTEXTO_POSICION;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssPOSICION_PEDIDO = (int) other.AttributeGet(IdPOSICION_PEDIDO);
ssMATERIAL = (string) other.AttributeGet(IdMATERIAL);
ssCENTRO = (string) other.AttributeGet(IdCENTRO);
ssALMACEN = (string) other.AttributeGet(IdALMACEN);
ssCANTIDAD_ENTRADA = (decimal) other.AttributeGet(IdCANTIDAD_ENTRADA);
ssTEXTO_POSICION = (string) other.AttributeGet(IdTEXTO_POSICION);
}
} // ST_d34c4878f870709fdbf7a3e48e70a4edStructure
/// <summary>
/// RecordList type <code>PI_ITEMList</code> that represents a record list of <code>PI_ITEM</code>
/// </summary>
public partial class RL_5f4f6d8d3b3fb597b315a01bc1951a9b : GenericRecordList<ST_d34c4878f870709fdbf7a3e48e70a4edStructure>, IEnumerable, IEnumerator {

protected override ST_d34c4878f870709fdbf7a3e48e70a4edStructure GetElementDefaultValue() {
return new ST_d34c4878f870709fdbf7a3e48e70a4edStructure();
}

public T[] ToArray<T>(Func<ST_d34c4878f870709fdbf7a3e48e70a4edStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_5f4f6d8d3b3fb597b315a01bc1951a9b recordList, Func<ST_d34c4878f870709fdbf7a3e48e70a4edStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_5f4f6d8d3b3fb597b315a01bc1951a9b(ST_d34c4878f870709fdbf7a3e48e70a4edStructure[] array) {
  RL_5f4f6d8d3b3fb597b315a01bc1951a9b result = new RL_5f4f6d8d3b3fb597b315a01bc1951a9b();
result.InnerFromArray(array);
    return result;
}

public static RL_5f4f6d8d3b3fb597b315a01bc1951a9b ToList<T>(T[] array, Func <T, ST_d34c4878f870709fdbf7a3e48e70a4edStructure> converter) {
  RL_5f4f6d8d3b3fb597b315a01bc1951a9b result = new RL_5f4f6d8d3b3fb597b315a01bc1951a9b();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_5f4f6d8d3b3fb597b315a01bc1951a9b FromRestList<T>(RestList<T> restList, Func <T, ST_d34c4878f870709fdbf7a3e48e70a4edStructure> converter) {
  RL_5f4f6d8d3b3fb597b315a01bc1951a9b result = new RL_5f4f6d8d3b3fb597b315a01bc1951a9b();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_5f4f6d8d3b3fb597b315a01bc1951a9b() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_d34c4878f870709fdbf7a3e48e70a4edStructure> NewList() {
return new RL_5f4f6d8d3b3fb597b315a01bc1951a9b();
}


} // RL_5f4f6d8d3b3fb597b315a01bc1951a9b
}

